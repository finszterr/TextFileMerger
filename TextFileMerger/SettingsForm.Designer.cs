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
            this.SuspendLayout();
            // 
            // uniqueCheckCheckBox
            // 
            this.uniqueCheckCheckBox.AutoSize = true;
            this.uniqueCheckCheckBox.Location = new System.Drawing.Point(58, 33);
            this.uniqueCheckCheckBox.Name = "uniqueCheckCheckBox";
            this.uniqueCheckCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uniqueCheckCheckBox.Size = new System.Drawing.Size(219, 21);
            this.uniqueCheckCheckBox.TabIndex = 1;
            this.uniqueCheckCheckBox.Text = "Every folder should be unique";
            this.uniqueCheckCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(336, 399);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(105, 39);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // deleteUnsuccessfulMergedCheckBox
            // 
            this.deleteUnsuccessfulMergedCheckBox.AutoSize = true;
            this.deleteUnsuccessfulMergedCheckBox.Location = new System.Drawing.Point(58, 314);
            this.deleteUnsuccessfulMergedCheckBox.Name = "deleteUnsuccessfulMergedCheckBox";
            this.deleteUnsuccessfulMergedCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteUnsuccessfulMergedCheckBox.Size = new System.Drawing.Size(320, 21);
            this.deleteUnsuccessfulMergedCheckBox.TabIndex = 3;
            this.deleteUnsuccessfulMergedCheckBox.Text = "Delete output file is merging was unsuccessful";
            this.deleteUnsuccessfulMergedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output";
            // 
            // rootLabel
            // 
            this.rootLabel.AutoSize = true;
            this.rootLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rootLabel.Location = new System.Drawing.Point(53, 72);
            this.rootLabel.Name = "rootLabel";
            this.rootLabel.Size = new System.Drawing.Size(131, 25);
            this.rootLabel.TabIndex = 5;
            this.rootLabel.Text = "Root directory";
            // 
            // rootDirectoryTextBox
            // 
            this.rootDirectoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rootDirectoryTextBox.Location = new System.Drawing.Point(58, 100);
            this.rootDirectoryTextBox.Name = "rootDirectoryTextBox";
            this.rootDirectoryTextBox.Size = new System.Drawing.Size(789, 53);
            this.rootDirectoryTextBox.TabIndex = 15;
            this.rootDirectoryTextBox.Text = "";
            // 
            // rootDirectoryButton
            // 
            this.rootDirectoryButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.rootDirectoryButton.Location = new System.Drawing.Point(853, 100);
            this.rootDirectoryButton.Name = "rootDirectoryButton";
            this.rootDirectoryButton.Size = new System.Drawing.Size(47, 53);
            this.rootDirectoryButton.TabIndex = 14;
            this.rootDirectoryButton.Text = "...";
            this.rootDirectoryButton.UseVisualStyleBackColor = true;
            this.rootDirectoryButton.Click += new System.EventHandler(this.rootDirectoryButton_Click);
            // 
            // defaultOutputNameLabel
            // 
            this.defaultOutputNameLabel.AutoSize = true;
            this.defaultOutputNameLabel.Location = new System.Drawing.Point(55, 344);
            this.defaultOutputNameLabel.Name = "defaultOutputNameLabel";
            this.defaultOutputNameLabel.Size = new System.Drawing.Size(238, 17);
            this.defaultOutputNameLabel.TabIndex = 16;
            this.defaultOutputNameLabel.Text = "Default output name (with extension)";
            // 
            // defaultOutputNameTextBox
            // 
            this.defaultOutputNameTextBox.Location = new System.Drawing.Point(309, 341);
            this.defaultOutputNameTextBox.Name = "defaultOutputNameTextBox";
            this.defaultOutputNameTextBox.Size = new System.Drawing.Size(300, 22);
            this.defaultOutputNameTextBox.TabIndex = 17;
            // 
            // clearSelectedFoldersListCheckBox
            // 
            this.clearSelectedFoldersListCheckBox.AutoSize = true;
            this.clearSelectedFoldersListCheckBox.Location = new System.Drawing.Point(58, 168);
            this.clearSelectedFoldersListCheckBox.Name = "clearSelectedFoldersListCheckBox";
            this.clearSelectedFoldersListCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearSelectedFoldersListCheckBox.Size = new System.Drawing.Size(304, 21);
            this.clearSelectedFoldersListCheckBox.TabIndex = 18;
            this.clearSelectedFoldersListCheckBox.Text = "Clear selected folders list before next select";
            this.clearSelectedFoldersListCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
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
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
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
    }
}