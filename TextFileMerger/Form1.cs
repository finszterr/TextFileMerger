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
        List<string> selectedFolders = new List<string>();
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
                    selectedFolders.Clear();
                    listBox1.Items.Clear();
                }

                bool uniqueFolder = Settings.Default.uniqueFolder;

                foreach (string folder in betterFolderBrowser.SelectedFolders)
                {
                    //Prevent error if selectedFolders in empty
                    if ((selectedFolders != null) && uniqueFolder && (selectedFolders.IndexOf(folder) > -1)) continue;
                    selectedFolders.Add(folder);
                }

                for (int i = 0; i < selectedFolders.Count; i++)
                {
                    listBox1.Items.Add(selectedFolders[i]);

                    if(includeFilesInSubfoldersCheckBox.Checked)
                    {
                        string[] subFolders = Directory.GetDirectories(selectedFolders[i], "*", SearchOption.AllDirectories);
                        foreach(string sub in subFolders)
                        {
                            listBox1.Items.Add(sub);                                                      
                        }
                    }
                }
                
                // If custom default output folder is set and is also valid then use that
                if(Settings.Default.isDefaultOutputFolderCustom
                    && Directory.Exists(Settings.Default.defaultOutputFolder))
                {
                    outputFileTextBox.Text = Settings.Default.defaultOutputFolder + "\\" + Settings.Default.defaultOutputName;
                } else
                {
                    //Or just use the first folder's path
                    outputFileTextBox.Text = selectedFolders[0] + "\\" + Settings.Default.defaultOutputName;
                }
                //Extension setting
                var firstFile = getFirstFile();
                if(Settings.Default.defaultOutputExtension == "" && firstFile != "")
                {
                    outputFileTextBox.Text += Path.GetExtension(firstFile);
                } else
                {
                    outputFileTextBox.Text += "." + Settings.Default.defaultOutputExtension;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            //Check if any folder is selected
            if(selectedFolders == null || selectedFolders.Count < 1)
            {
                MessageBox.Show(
                   "There aren't any folders selected!",
                   "Folder selection error",
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
                    //Ignore empty files
                    //An empty file is created if the output has been manualy selected
                    //and not just automatically filled when source folders have been added
                    long outputFileSize = new FileInfo(outputFileTextBox.Text).Length;
                    if (outputFileSize != 0) {
                        if (MessageBox.Show(
                            "The file " + Path.GetFileName(outputFileTextBox.Text) + " already exists. " +
                            "Do you want to overwrite it?",
                            "Confirm overwrite",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                    }
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
                //Handle error if there isn't any file
                var lastFile = "";
                if (Directory.GetFiles(folder).Length > 0)
                    lastFile = Directory.EnumerateFiles(folder).Last();
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

                    //Get back a string if we do not want to start file in new line
                    string lastBeginningLine = WriteBeginning(sw, Path.GetFileName(file.ToString()));
                    bool firstLine = true;
                    //Count the lines in the current file
                    long numberOfLines = 0;
                    if (textAfterNoNewLineCheckBox.Checked)
                    {
                        using (var reader = File.OpenText(file.ToString()))
                        {
                            while (reader.ReadLine() != null)
                            {
                                numberOfLines++;
                            }
                        }
                    }
                    string lastLineStr = "";
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
                        long lineCounter = 0;
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            //Ending - save last line but do not write yet!
                            if (textAfterNoNewLineCheckBox.Checked && lineCounter == numberOfLines)
                            {
                                lastLineStr = s;
                                break;
                            }
                            //Beginning
                            if (firstLine)
                                sw.WriteLine(lastBeginningLine + s);
                            else
                                sw.WriteLine(s);
                            if (firstLine) firstLine = false;
                            lineCounter++;
                        }

                    }
                    //Ending text - write it and the last line if it is not added yet
                    WriteEnding(sw, Path.GetFileName(file.ToString()), lastLineStr);

                    //Between files text
                    if (folder == lastFolder && file != lastFile)
                    {
                        WriteBetween(sw);
                    }
                }
            }
            //Close after every folder and every files are proceessed
            sw.Close();

            //Clear selected folders if needed
            if(Settings.Default.removeSelectedFoldersAfterProcessing)
            {
                selectedFolders.Clear();
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

        private string WriteBeginning(StreamWriter sw, string fileName)
        {
            int len = beforeTextBox.Lines.Length;
            if (textBeforeNoNewLineCheckBox.Checked) len--;
            for (int i = 0; i < len; i++)
            {
                string line = beforeTextBox.Lines[i].Replace("[FileName]", fileName);
                sw.WriteLine(line);
            }
            if (textBeforeNoNewLineCheckBox.Checked)
            {
                string lastLine =
                    beforeTextBox.Lines[beforeTextBox.Lines.Count() - 1].Replace("[FileName]", fileName);
                return lastLine;
            }

            return "";                
        }

        private void WriteEnding(StreamWriter sw, string fileName, string lastLineStr)
        {
            int start = 0;
            if (textAfterNoNewLineCheckBox.Checked)
            {
                string lastLine = afterTextBox.Lines[0].Replace("[FileName]", fileName);
                sw.WriteLine(lastLineStr + lastLine);
                start++;
            }
            for (int i = start; i < afterTextBox.Lines.Length; i++)
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
                selectedFolders.RemoveAt(selectedIndex);
                listBox1.Items.RemoveAt(selectedIndex);
                //If it was the last item we do not need to select any another
                if(listBox1.Items.Count != 0)
                {
                    listBox1.SetSelected(Math.Min(selectedIndex, listBox1.Items.Count - 1), true);
                }
            }
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

        string getFirstFile()
        {
            //Loop in the first folder
            foreach (string file in Directory.EnumerateFiles(selectedFolders.First()))
            {
                return file;
            }

            return "";
        }

        private void clearAllSelectedFoldersButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            selectedFolders.Clear();
        }
    }
}
