using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileMerger.Properties;
using WK.Libraries.BetterFolderBrowserNS;

namespace TextFileMerger
{
    public partial class mainForm : Form
    {
        string[] selectedFolders = new string[0];
        public mainForm()
        {
            InitializeComponent();
            //maskedTextBox1.Text = (string)Settings.Default["test"];
        }

         void button1_Click_1(object sender, EventArgs e)
        {
            BetterFolderBrowser betterFolderBrowser = new BetterFolderBrowser();
            betterFolderBrowser.Title = "Select folders...";
            betterFolderBrowser.RootFolder = Settings.Default.rootDirectory;

            // Allow multi-selection of folders.
            betterFolderBrowser.Multiselect = true;

            if (betterFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                if(Settings.Default.clearSelectedFolderListBeforeNextSelect)
                {
                    selectedFolders = new string[0];
                    listBox1.Items.Clear();
                }

                bool uniqueFolder = Settings.Default.uniqueFolder;
                List<string> selectedFoldersList = new List<string>();

                foreach (string folder in betterFolderBrowser.SelectedFolders)
                {
                    //Prevent error if selectedFolders in empty
                    if ((selectedFolders != null) && uniqueFolder
                        && (Array.IndexOf(selectedFolders, folder) > -1)) continue;
                    selectedFoldersList.Add(folder);
                }

                for (int i = 0; i < selectedFoldersList.Count; i++)
                {
                    listBox1.Items.Add(selectedFoldersList[i]);

                    if(includeFilesInSubfoldersCheckBox.Checked)
                    {
                        string[] subFolders = Directory.GetDirectories(selectedFoldersList[i], "*", SearchOption.AllDirectories);
                        foreach(string sub in subFolders)
                        {
                            listBox1.Items.Add(sub);                                                      
                        }
                    }
                }
                //Add new folders to the already added's list
                selectedFolders = selectedFolders.Concat(selectedFoldersList.ToArray()).ToArray();
                // If you've disabled multi-selection, use 'SelectedFolder'.
                // string selectedFolder = betterFolderBrowser1.SelectedFolder;
                outputFileTextBox.Text = selectedFolders[0] + "\\" + Settings.Default.defaultOutputName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            //Check if any folder is selected
            if(selectedFolders == null || selectedFolders.Length < 1)
            {
                MessageBox.Show(
                   "There aren't any folders selected!",
                   "Folder selecton error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
                );
                return;
            }

            //Creating output file
            FileStream merged;
            try
            {
                //Check if file already exist in this folder
                if (File.Exists(outputFileTextBox.Text))
                {
                    if (MessageBox.Show(
                        "The file " + Path.GetFileName(outputFileTextBox.Text) + " already exists. " +
                        "Do you want to overwrite it?",
                        "Confirm overwrite",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                }
                //Create the outpuf file
                merged = File.Create(outputFileTextBox.Text);
                merged.Close();
                sw = File.AppendText(outputFileTextBox.Text);
                //Copy full path and filename back to the textbox
                outputFileTextBox.Text = merged.Name;
            }
            catch (Exception)
            {
                MessageBox.Show("Output file cannot be created!", "Output file error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long numberOfProcessedFiles = 0;
            long numberOfProcessedFolders = 0;
            //Processing folders
            var lastFolder = selectedFolders.Last();
            foreach (var folder in selectedFolders)
            {
                bool folderAdded = false;
                if (!Directory.Exists(folder))
                {
                    MessageBox.Show("Selected folder does not exist!", "Selected folder error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sw.Close();
                    if (Settings.Default.deleteUnsuccessfulMerged) File.Delete(outputFileTextBox.Text);
                    return;
                }

                //Last file in the last folder
                var lastFile = Directory.EnumerateFiles(folder).Last();
                foreach (var file in Directory.EnumerateFiles(folder))
                {
                    if (file.ToString() == merged.Name) continue;
                    if (!folderAdded)
                    {
                        numberOfProcessedFolders++;
                        folderAdded = true;
                    }
                    numberOfProcessedFiles++;
                    //Check big files
                    if (skipBigFilesCheckBox.Checked)
                    {
                        try
                        {
                            long fileSize = new FileInfo(file).Length;
                            if (fileSize > Int32.Parse(skipBigFilesTextBox.Text)) continue;
                        }
                        catch (Exception)
                        {
                            if (MessageBox.Show(
                            "We couldn't determine the file sizes. Continue?",
                            "File size check error",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;

                        }
                    }

                    using (StreamReader sr = File.OpenText(file.ToString()))
                    {
                        /* // FR TODO: encoding
                        sr.Peek(); // you need this!
                        var encoding = sr.CurrentEncoding;
                        if (MessageBox.Show(
                        "Format " + encoding,
                        "First file format",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;
                        */
                        WriteBeginning(sw, Path.GetFileName(file.ToString()));
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(s);
                        }

                        WriteEnding(sw, Path.GetFileName(file.ToString()));

                        //Between files text
                        if (folder == lastFolder && file != lastFile)
                        {
                            WriteBetween(sw);
                        }
                    }
                }
            }
            //Close after every folder and every files are proceessed
            sw.Close();

            //Clear selected folders if needed
            if(Settings.Default.removeSelectedFoldersAfterProcessing)
            {
                selectedFolders = new string[0];
                listBox1.Items.Clear();
            }

            SuccessForm successForm = new SuccessForm();
            //Creating target folder link
            LinkLabel linkLabel1 = (LinkLabel)successForm.Controls["linkLabel1"];
            linkLabel1.Text = "Open target folder";
            linkLabel1.Click += new EventHandler(linkLabel1_Click);

            void linkLabel1_Click(object s, EventArgs ea)
            {
                Process.Start(Path.GetDirectoryName(outputFileTextBox.Text));
            }

            //Creating output file link
            LinkLabel linkLabel2 = (LinkLabel)successForm.Controls["linkLabel2"];
            linkLabel2.Text = "Open output file";
            linkLabel2.Click += new EventHandler(linkLabel2_Click);
            //Processed files and folders label setting
            Label processedLabel = (Label)successForm.Controls["processedLabel"];
            string processedFilesText;
            string processedFoldersText;
            string processText;

            if(numberOfProcessedFiles < 2)
            {
                processedFilesText = numberOfProcessedFiles + " file in ";
            } else
            {
                processedFilesText = numberOfProcessedFiles + " files in ";
            }
                
            if(numberOfProcessedFolders < 2)
            {
                processedFoldersText = numberOfProcessedFolders + " folder";
            } else
            {
                processedFoldersText = numberOfProcessedFolders + " folders";
            }

            if (numberOfProcessedFiles < 2)
            {
                processText = " has been processed.";
            }
            else
            {
                processText = " have been processed.";
            }

            processedLabel.Text = processedFilesText + processedFoldersText + processText;

            void linkLabel2_Click(object s, EventArgs ea)
            {
                //Open up your file with it's associated editor
                Process.Start(outputFileTextBox.Text);
            }

            successForm.Show();
        }

        private void outputFileButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save the merged file...";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    outputFileTextBox.Text = saveFileDialog.FileName;
                }
            }
        }

        private void WriteBeginning(StreamWriter sw, string fileName)
        {
            for (int i = 0; i < beforeTextBox.Lines.Length; i++)
            {
                string line = beforeTextBox.Lines[i].Replace("[FileName]", fileName);
                sw.WriteLine(line);
            }
        }

        private void WriteEnding(StreamWriter sw, string fileName)
        {
            for (int i = 0; i < afterTextBox.Lines.Length; i++)
            {
                string line = afterTextBox.Lines[i].Replace("[FileName]", fileName);
                sw.WriteLine(line);
            }
        }

        private void WriteBetween(StreamWriter sw)
        {
            if (betweenTextBox.Text == "") return; // do not write anything (not even empty line)
            for (int i = 0; i < betweenTextBox.Lines.Length; i++)
            {
                sw.WriteLine(betweenTextBox.Lines[i]);
            }
        }

        private void deleteSelectedFolderButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            //Is there any folder selected?
            if (selectedIndex != -1)
            {
                //Make a list so we can remove a specific item easily
                var selectedFoldersList = new List<String>(selectedFolders);

                selectedFoldersList.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
                selectedFolders = selectedFoldersList.ToArray();
                //If it was the last item we do not need to select any another
                if(listBox1.Items.Count != 0)
                {
                    listBox1.SetSelected(Math.Min(selectedIndex, listBox1.Items.Count - 1), true);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            selectedFolders = null;
        }

        private void skipBigFilesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point (. or ,)
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void skipBigFilesTextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            string[] valueArray = skipBigFilesTextBox.Text.ToCharArray().Select(c => c.ToString()).ToArray();
            var valueUnformatted = "";

            foreach (string c in valueArray)
            {
                var isNumeric = int.TryParse(c, out int n);
                if (isNumeric || c == ".")
                {
                    valueUnformatted += c;
                }
                
            }
            double bf = Convert.ToDouble(skipBigFilesTextBox.Text);
            bf = 10.1022;
            skipBigFilesTextBox.Text = bf.ToString("F", CultureInfo.InvariantCulture);
            */
            //decimal value;
            //decimal.TryParse(skipBigFilesTextBox.Text, out value);
            //Console.WriteLine(value.ToString("N2"));
            //skipBigFilesTextBox.Text = value.ToString("N2");
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // save setting
            //Settings.Default["test"] = maskedTextBox1.Text;

            // you can force a save with
            //Settings.Default.Save();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
