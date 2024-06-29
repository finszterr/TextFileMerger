namespace TextFileMerger
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uniqueCheckCheckBox = new System.Windows.Forms.CheckBox();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.deleteUnsuccessfulMergedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rootLabel = new System.Windows.Forms.Label();
            this.rootDirectoryTextBox = new System.Windows.Forms.RichTextBox();
            this.rootDirectoryButton = new System.Windows.Forms.Button();
            this.defaultOutputNameLabel = new System.Windows.Forms.Label();
            this.defaultOutputNameTextBox = new System.Windows.Forms.TextBox();
            this.clearSelectedFoldersListCheckBox = new System.Windows.Forms.CheckBox();
            this.removeSelectedFoldersAfterProcessingCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultOutputFolderLabel = new System.Windows.Forms.Label();
            this.defaultOutputFolderComboBox = new System.Windows.Forms.ComboBox();
            this.defaultOutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.defaultOutputFolderButton = new System.Windows.Forms.Button();
            this.defaultOutputExtensionLabel = new System.Windows.Forms.Label();
            this.defaultOutputExtensionWaterMarkTextBox = new TextFileMerger.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // uniqueCheckCheckBox
            // 
            this.uniqueCheckCheckBox.AutoSize = true;
            this.uniqueCheckCheckBox.Location = new System.Drawing.Point(41, 27);
            this.uniqueCheckCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uniqueCheckCheckBox.Name = "uniqueCheckCheckBox";
            this.uniqueCheckCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uniqueCheckCheckBox.Size = new System.Drawing.Size(166, 17);
            this.uniqueCheckCheckBox.TabIndex = 1;
            this.uniqueCheckCheckBox.Text = "Every folder should be unique";
            this.uniqueCheckCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(294, 393);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(79, 32);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // deleteUnsuccessfulMergedCheckBox
            // 
            this.deleteUnsuccessfulMergedCheckBox.AutoSize = true;
            this.deleteUnsuccessfulMergedCheckBox.Location = new System.Drawing.Point(40, 255);
            this.deleteUnsuccessfulMergedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteUnsuccessfulMergedCheckBox.Name = "deleteUnsuccessfulMergedCheckBox";
            this.deleteUnsuccessfulMergedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteUnsuccessfulMergedCheckBox.Size = new System.Drawing.Size(243, 17);
            this.deleteUnsuccessfulMergedCheckBox.TabIndex = 3;
            this.deleteUnsuccessfulMergedCheckBox.Text = "Delete output file is merging was unsuccessful";
            this.deleteUnsuccessfulMergedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // rootLabel
            // 
            this.rootLabel.AutoSize = true;
            this.rootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rootLabel.Location = new System.Drawing.Point(40, 58);
            this.rootLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rootLabel.Name = "rootLabel";
            this.rootLabel.Size = new System.Drawing.Size(108, 20);
            this.rootLabel.TabIndex = 5;
            this.rootLabel.Text = "Root directory";
            // 
            // rootDirectoryTextBox
            // 
            this.rootDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rootDirectoryTextBox.Location = new System.Drawing.Point(44, 81);
            this.rootDirectoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rootDirectoryTextBox.Name = "rootDirectoryTextBox";
            this.rootDirectoryTextBox.Size = new System.Drawing.Size(593, 44);
            this.rootDirectoryTextBox.TabIndex = 15;
            this.rootDirectoryTextBox.Text = "";
            // 
            // rootDirectoryButton
            // 
            this.rootDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.rootDirectoryButton.Location = new System.Drawing.Point(640, 81);
            this.rootDirectoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rootDirectoryButton.Name = "rootDirectoryButton";
            this.rootDirectoryButton.Size = new System.Drawing.Size(35, 43);
            this.rootDirectoryButton.TabIndex = 14;
            this.rootDirectoryButton.Text = "...";
            this.rootDirectoryButton.UseVisualStyleBackColor = true;
            this.rootDirectoryButton.Click += new System.EventHandler(this.rootDirectoryButton_Click);
            // 
            // defaultOutputNameLabel
            // 
            this.defaultOutputNameLabel.AutoSize = true;
            this.defaultOutputNameLabel.Location = new System.Drawing.Point(41, 280);
            this.defaultOutputNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defaultOutputNameLabel.Name = "defaultOutputNameLabel";
            this.defaultOutputNameLabel.Size = new System.Drawing.Size(194, 13);
            this.defaultOutputNameLabel.TabIndex = 16;
            this.defaultOutputNameLabel.Text = "Default output name (without extension)";
            // 
            // defaultOutputNameTextBox
            // 
            this.defaultOutputNameTextBox.Location = new System.Drawing.Point(253, 277);
            this.defaultOutputNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultOutputNameTextBox.Name = "defaultOutputNameTextBox";
            this.defaultOutputNameTextBox.Size = new System.Drawing.Size(366, 20);
            this.defaultOutputNameTextBox.TabIndex = 17;
            // 
            // clearSelectedFoldersListCheckBox
            // 
            this.clearSelectedFoldersListCheckBox.AutoSize = true;
            this.clearSelectedFoldersListCheckBox.Location = new System.Drawing.Point(44, 136);
            this.clearSelectedFoldersListCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearSelectedFoldersListCheckBox.Name = "clearSelectedFoldersListCheckBox";
            this.clearSelectedFoldersListCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearSelectedFoldersListCheckBox.Size = new System.Drawing.Size(229, 17);
            this.clearSelectedFoldersListCheckBox.TabIndex = 18;
            this.clearSelectedFoldersListCheckBox.Text = "Clear selected folders list before next select";
            this.clearSelectedFoldersListCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeSelectedFoldersAfterProcessingCheckBox
            // 
            this.removeSelectedFoldersAfterProcessingCheckBox.AutoSize = true;
            this.removeSelectedFoldersAfterProcessingCheckBox.Location = new System.Drawing.Point(44, 167);
            this.removeSelectedFoldersAfterProcessingCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeSelectedFoldersAfterProcessingCheckBox.Name = "removeSelectedFoldersAfterProcessingCheckBox";
            this.removeSelectedFoldersAfterProcessingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.removeSelectedFoldersAfterProcessingCheckBox.Size = new System.Drawing.Size(273, 17);
            this.removeSelectedFoldersAfterProcessingCheckBox.TabIndex = 19;
            this.removeSelectedFoldersAfterProcessingCheckBox.Text = "Clear selected folders list after successful processing";
            this.removeSelectedFoldersAfterProcessingCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultOutputFolderLabel
            // 
            this.defaultOutputFolderLabel.AutoSize = true;
            this.defaultOutputFolderLabel.Location = new System.Drawing.Point(41, 336);
            this.defaultOutputFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defaultOutputFolderLabel.Name = "defaultOutputFolderLabel";
            this.defaultOutputFolderLabel.Size = new System.Drawing.Size(103, 13);
            this.defaultOutputFolderLabel.TabIndex = 20;
            this.defaultOutputFolderLabel.Text = "Default output folder";
            // 
            // defaultOutputFolderComboBox
            // 
            this.defaultOutputFolderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultOutputFolderComboBox.FormattingEnabled = true;
            this.defaultOutputFolderComboBox.Location = new System.Drawing.Point(166, 336);
            this.defaultOutputFolderComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultOutputFolderComboBox.Name = "defaultOutputFolderComboBox";
            this.defaultOutputFolderComboBox.Size = new System.Drawing.Size(185, 21);
            this.defaultOutputFolderComboBox.TabIndex = 21;
            this.defaultOutputFolderComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultOutputFolderComboBox_SelectedIndexChanged);
            // 
            // defaultOutputFolderTextBox
            // 
            this.defaultOutputFolderTextBox.Location = new System.Drawing.Point(371, 336);
            this.defaultOutputFolderTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultOutputFolderTextBox.Name = "defaultOutputFolderTextBox";
            this.defaultOutputFolderTextBox.Size = new System.Drawing.Size(265, 20);
            this.defaultOutputFolderTextBox.TabIndex = 22;
            // 
            // defaultOutputFolderButton
            // 
            this.defaultOutputFolderButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.defaultOutputFolderButton.Location = new System.Drawing.Point(638, 336);
            this.defaultOutputFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultOutputFolderButton.Name = "defaultOutputFolderButton";
            this.defaultOutputFolderButton.Size = new System.Drawing.Size(35, 30);
            this.defaultOutputFolderButton.TabIndex = 23;
            this.defaultOutputFolderButton.Text = "...";
            this.defaultOutputFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.defaultOutputFolderButton.UseVisualStyleBackColor = true;
            // 
            // defaultOutputExtensionLabel
            // 
            this.defaultOutputExtensionLabel.AutoSize = true;
            this.defaultOutputExtensionLabel.Location = new System.Drawing.Point(42, 302);
            this.defaultOutputExtensionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defaultOutputExtensionLabel.Name = "defaultOutputExtensionLabel";
            this.defaultOutputExtensionLabel.Size = new System.Drawing.Size(330, 13);
            this.defaultOutputExtensionLabel.TabIndex = 24;
            this.defaultOutputExtensionLabel.Text = "Output file\'s extension (if empty then first file\'s extension will be used!)";
            // 
            // defaultOutputExtensionWaterMarkTextBox
            // 
            this.defaultOutputExtensionWaterMarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.defaultOutputExtensionWaterMarkTextBox.Location = new System.Drawing.Point(380, 298);
            this.defaultOutputExtensionWaterMarkTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defaultOutputExtensionWaterMarkTextBox.Name = "defaultOutputExtensionWaterMarkTextBox";
            this.defaultOutputExtensionWaterMarkTextBox.Size = new System.Drawing.Size(239, 19);
            this.defaultOutputExtensionWaterMarkTextBox.TabIndex = 26;
            this.defaultOutputExtensionWaterMarkTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.defaultOutputExtensionWaterMarkTextBox.WaterMarkText = "E.g. if you want txt files then type: txt (no \".\" needed)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 444);
            this.Controls.Add(this.defaultOutputExtensionWaterMarkTextBox);
            this.Controls.Add(this.defaultOutputExtensionLabel);
            this.Controls.Add(this.defaultOutputFolderButton);
            this.Controls.Add(this.defaultOutputFolderTextBox);
            this.Controls.Add(this.defaultOutputFolderComboBox);
            this.Controls.Add(this.defaultOutputFolderLabel);
            this.Controls.Add(this.removeSelectedFoldersAfterProcessingCheckBox);
            this.Controls.Add(this.clearSelectedFoldersListCheckBox);
            this.Controls.Add(this.defaultOutputNameTextBox);
            this.Controls.Add(this.defaultOutputNameLabel);
            this.Controls.Add(this.rootDirectoryTextBox);
            this.Controls.Add(this.rootDirectoryButton);
            this.Controls.Add(this.rootLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteUnsuccessfulMergedCheckBox);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.uniqueCheckCheckBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox uniqueCheckCheckBox;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox deleteUnsuccessfulMergedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rootLabel;
        private System.Windows.Forms.RichTextBox rootDirectoryTextBox;
        private System.Windows.Forms.Button rootDirectoryButton;
        private System.Windows.Forms.Label defaultOutputNameLabel;
        private System.Windows.Forms.TextBox defaultOutputNameTextBox;
        private System.Windows.Forms.CheckBox clearSelectedFoldersListCheckBox;
        private System.Windows.Forms.CheckBox removeSelectedFoldersAfterProcessingCheckBox;
        private System.Windows.Forms.Label defaultOutputFolderLabel;
        private System.Windows.Forms.ComboBox defaultOutputFolderComboBox;
        private System.Windows.Forms.TextBox defaultOutputFolderTextBox;
        private System.Windows.Forms.Button defaultOutputFolderButton;
        private System.Windows.Forms.Label defaultOutputExtensionLabel;
        private WaterMarkTextBox defaultOutputExtensionWaterMarkTextBox;
    }
}