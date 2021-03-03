using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileMerger.Properties;
using WK.Libraries.BetterFolderBrowserNS;

namespace TextFileMerger
{
    public partial class SettingsForm : Form
    {
        //Init combobox
        string[] outputs = { "Same as the firstly added folder", "Custom ..." };
        public SettingsForm()
        {
            InitializeComponent();
            defaultOutputFolderComboBox.Items.Add(outputs[0]);
            defaultOutputFolderComboBox.Items.Add(outputs[1]);

            if (Settings.Default.uniqueFolder)
                uniqueCheckCheckBox.CheckState = CheckState.Checked;
            if (Settings.Default.deleteUnsuccessfulMerged)
                deleteUnsuccessfulMergedCheckBox.CheckState = CheckState.Checked;

            rootDirectoryTextBox.Text = Settings.Default.rootDirectory;
            defaultOutputNameTextBox.Text = Settings.Default.defaultOutputName;

            if (Settings.Default.clearSelectedFolderListBeforeNextSelect)
                clearSelectedFoldersListCheckBox.CheckState = CheckState.Checked;

            if (Settings.Default.removeSelectedFoldersAfterProcessing)
                removeSelectedFoldersAfterProcessingCheckBox.CheckState = CheckState.Checked;

            if (Settings.Default.isDefaultOutputFolderCustom)
            {
                defaultOutputFolderComboBox.Text = outputs[1];
                defaultOutputFolderTextBox.Visible = true;
                defaultOutputFolderButton.Visible = true;
            }
            else
            {
                defaultOutputFolderComboBox.Text = outputs[0];
                defaultOutputFolderTextBox.Visible = false;
                defaultOutputFolderButton.Visible = false;
            }

            if (Settings.Default.defaultOutputFolder != "")
                defaultOutputFolderTextBox.Text = Settings.Default.defaultOutputFolder;

            if (Settings.Default.defaultOutputExtension != "")
                defaultOutputExtensionWaterMarkTextBox.Text = Settings.Default.defaultOutputExtension;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void rootDirectoryButton_Click(object sender, EventArgs e)
        {
            BetterFolderBrowser betterFolderBrowser = new BetterFolderBrowser();
            betterFolderBrowser.Title = "Select root folder";
            betterFolderBrowser.RootFolder = Settings.Default.rootDirectory;
            betterFolderBrowser.Multiselect = false;

            if (betterFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                rootDirectoryTextBox.Text = betterFolderBrowser.SelectedFolder;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved())
            {
                if (MessageBox.Show(
                "The settings are not saved" + Environment.NewLine + "Do you want to save them?",
                "Settings saving...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) saveSettings();
            }
        }

        void saveSettings()
        {
            //save setting
            Settings.Default["uniqueFolder"] = uniqueCheckCheckBox.Checked;
            Settings.Default["deleteUnsuccessfulMerged"] = deleteUnsuccessfulMergedCheckBox.Checked;
            //Check if path is valid before saving
            if (Directory.Exists(rootDirectoryTextBox.Text))
            {
                Settings.Default["rootDirectory"] = rootDirectoryTextBox.Text;
            }
            else
            {
                if (MessageBox.Show(
                   "The root directory you set is not valid!" + Environment.NewLine + "Restore the previous value?",
                   "Invalid root directory",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                   //Restore the last good dir
                   rootDirectoryTextBox.Text = Settings.Default.rootDirectory;
            }
            //Default output name
            bool isValid = !string.IsNullOrEmpty(defaultOutputNameTextBox.Text) &&
              defaultOutputNameTextBox.Text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
            if (isValid)
                Settings.Default["defaultOutputName"] = defaultOutputNameTextBox.Text;
            else
                if (MessageBox.Show(
                   "The default output name you set is not valid!" + Environment.NewLine + "Restore the previous value?",
                   "Invalid output name",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                defaultOutputNameTextBox.Text = Settings.Default.defaultOutputName;

            Settings.Default["clearSelectedFolderListBeforeNextSelect"] = clearSelectedFoldersListCheckBox.Checked;
            Settings.Default["removeSelectedFoldersAfterProcessing"] = removeSelectedFoldersAfterProcessingCheckBox.Checked;

            Settings.Default["isDefaultOutputFolderCustom"] = defaultOutputFolderComboBox.Text == outputs[1];

            if (Directory.Exists(defaultOutputFolderTextBox.Text))
            {
                Settings.Default["defaultOutputFolder"] = defaultOutputFolderTextBox.Text;
            } 
            else
            {
                //Not custom - allow not valid dirs as well like empty
                if(defaultOutputFolderComboBox.Text == outputs[1])
                {
                    if (MessageBox.Show(
                       "The default output folder you set is not valid!" + Environment.NewLine + "Restore the previous value?",
                       "Invalid output folder",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        defaultOutputFolderTextBox.Text = Settings.Default.defaultOutputFolder;
                } 
            }

            Settings.Default["defaultOutputExtension"] = defaultOutputExtensionWaterMarkTextBox.Text;

            // you can force a save with
            Settings.Default.Save();
        }

        bool isSaved()
        {
            if (uniqueCheckCheckBox.Checked != Settings.Default.uniqueFolder) return false;
            if (deleteUnsuccessfulMergedCheckBox.Checked != Settings.Default.deleteUnsuccessfulMerged) return false;
            if(rootDirectoryTextBox.Text != Settings.Default.rootDirectory) return false;
            if(defaultOutputNameTextBox.Text != Settings.Default.defaultOutputName) return false;
            if(clearSelectedFoldersListCheckBox.Checked != Settings.Default.clearSelectedFolderListBeforeNextSelect) return false;
            if (removeSelectedFoldersAfterProcessingCheckBox.Checked != Settings.Default.removeSelectedFoldersAfterProcessing)
                return false;
            if (Settings.Default.isDefaultOutputFolderCustom && defaultOutputFolderComboBox.Text != outputs[1])
                return false;
            if (!Settings.Default.isDefaultOutputFolderCustom && defaultOutputFolderComboBox.Text == outputs[1])
                return false;
            if (defaultOutputFolderTextBox.Text != Settings.Default.defaultOutputFolder) return false;
            if (defaultOutputExtensionWaterMarkTextBox.Text != Settings.Default.defaultOutputExtension) return false;

            return true;
        }

        private void defaultOutputFolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultOutputFolderComboBox.Text == outputs[1])
            {
                defaultOutputFolderTextBox.Visible = true;
                defaultOutputFolderButton.Visible = true;
            }
            if (defaultOutputFolderComboBox.Text == outputs[0])
            {
                defaultOutputFolderTextBox.Visible = false;
                defaultOutputFolderButton.Visible = false;
            }
        }

    }
}
