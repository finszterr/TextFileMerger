namespace TextFileMerger
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.selectedLabel = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.beforeLabel = new System.Windows.Forms.Label();
            this.afterLabel = new System.Windows.Forms.Label();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.betweenLabel = new System.Windows.Forms.Label();
            this.beforeTextBox = new System.Windows.Forms.RichTextBox();
            this.outputFileTextBox = new System.Windows.Forms.RichTextBox();
            this.afterTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.betweenTextBox = new System.Windows.Forms.RichTextBox();
            this.betterFolderBrowser1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearAllSelectedFoldersButton = new System.Windows.Forms.Button();
            this.includeFilesInSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.skipBigFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.skipBigFilesLabel = new System.Windows.Forms.Label();
            this.skipBigFilesTextBox = new System.Windows.Forms.TextBox();
            this.UoMLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.textAfterNoNewLineCheckBox = new System.Windows.Forms.CheckBox();
            this.textBeforeNoNewLineCheckBox = new System.Windows.Forms.CheckBox();
            this.textBetweenNotNewLineCheckBox = new System.Windows.Forms.CheckBox();
            this.mergeNextFileInSameLineCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedLabel.Location = new System.Drawing.Point(22, 15);
            this.selectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(142, 25);
            this.selectedLabel.TabIndex = 0;
            this.selectedLabel.Text = "Selected folder:";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.selectFolderButton.Location = new System.Drawing.Point(804, 46);
            this.selectFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(35, 68);
            this.selectFolderButton.TabIndex = 2;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mergeButton
            // 
            this.mergeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.mergeButton.Location = new System.Drawing.Point(389, 584);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(92, 36);
            this.mergeButton.TabIndex = 0;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beforeLabel.Location = new System.Drawing.Point(22, 323);
            this.beforeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(221, 25);
            this.beforeLabel.TabIndex = 3;
            this.beforeLabel.Text = "Text before each text file:";
            this.toolTip.SetToolTip(this.beforeLabel, "[FileName] and [FilePath] strings will be replaced with the actual values.");
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.afterLabel.Location = new System.Drawing.Point(446, 323);
            this.afterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(205, 25);
            this.afterLabel.TabIndex = 5;
            this.afterLabel.Text = "Text after each text file:";
            this.toolTip.SetToolTip(this.afterLabel, "[FileName] and [FilePath] strings will be replaced with the actual values.");
            // 
            // outputFileButton
            // 
            this.outputFileButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.outputFileButton.Location = new System.Drawing.Point(804, 267);
            this.outputFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(35, 43);
            this.outputFileButton.TabIndex = 9;
            this.outputFileButton.Text = "...";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputFileLabel.Location = new System.Drawing.Point(22, 230);
            this.outputFileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(106, 25);
            this.outputFileLabel.TabIndex = 7;
            this.outputFileLabel.Text = "Output file:";
            // 
            // betweenLabel
            // 
            this.betweenLabel.AutoSize = true;
            this.betweenLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betweenLabel.Location = new System.Drawing.Point(22, 453);
            this.betweenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betweenLabel.Name = "betweenLabel";
            this.betweenLabel.Size = new System.Drawing.Size(195, 25);
            this.betweenLabel.TabIndex = 17;
            this.betweenLabel.Text = "Between the text files:";
            // 
            // beforeTextBox
            // 
            this.beforeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.beforeTextBox.Location = new System.Drawing.Point(27, 361);
            this.beforeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beforeTextBox.Name = "beforeTextBox";
            this.beforeTextBox.Size = new System.Drawing.Size(390, 81);
            this.beforeTextBox.TabIndex = 12;
            this.beforeTextBox.Text = "*** Beginning of [FileName]";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.outputFileTextBox.Location = new System.Drawing.Point(27, 267);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(774, 44);
            this.outputFileTextBox.TabIndex = 13;
            this.outputFileTextBox.Text = "";
            // 
            // afterTextBox
            // 
            this.afterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.afterTextBox.Location = new System.Drawing.Point(451, 361);
            this.afterTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.afterTextBox.Name = "afterTextBox";
            this.afterTextBox.Size = new System.Drawing.Size(390, 81);
            this.afterTextBox.TabIndex = 14;
            this.afterTextBox.Text = "*** End of [FileName]";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(266, 323);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // betweenTextBox
            // 
            this.betweenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.betweenTextBox.Location = new System.Drawing.Point(27, 492);
            this.betweenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betweenTextBox.Name = "betweenTextBox";
            this.betweenTextBox.Size = new System.Drawing.Size(813, 81);
            this.betweenTextBox.TabIndex = 18;
            this.betweenTextBox.Text = "";
            // 
            // betterFolderBrowser1
            // 
            this.betterFolderBrowser1.Multiselect = false;
            this.betterFolderBrowser1.RootFolder = "C:\\Users\\finszterr\\Desktop";
            this.betterFolderBrowser1.Title = "Please select a folder...";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(27, 46);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(774, 69);
            this.listBox1.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearAllSelectedFoldersButton
            // 
            this.clearAllSelectedFoldersButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clearAllSelectedFoldersButton.Location = new System.Drawing.Point(844, 90);
            this.clearAllSelectedFoldersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearAllSelectedFoldersButton.Name = "clearAllSelectedFoldersButton";
            this.clearAllSelectedFoldersButton.Size = new System.Drawing.Size(50, 24);
            this.clearAllSelectedFoldersButton.TabIndex = 21;
            this.clearAllSelectedFoldersButton.Text = "Clear";
            this.clearAllSelectedFoldersButton.UseVisualStyleBackColor = true;
            this.clearAllSelectedFoldersButton.Click += new System.EventHandler(this.clearAllSelectedFoldersButton_Click);
            // 
            // includeFilesInSubfoldersCheckBox
            // 
            this.includeFilesInSubfoldersCheckBox.AutoSize = true;
            this.includeFilesInSubfoldersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includeFilesInSubfoldersCheckBox.Location = new System.Drawing.Point(180, 15);
            this.includeFilesInSubfoldersCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.includeFilesInSubfoldersCheckBox.Name = "includeFilesInSubfoldersCheckBox";
            this.includeFilesInSubfoldersCheckBox.Size = new System.Drawing.Size(186, 21);
            this.includeFilesInSubfoldersCheckBox.TabIndex = 23;
            this.includeFilesInSubfoldersCheckBox.Text = "Include files in subfolders";
            this.includeFilesInSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // skipBigFilesCheckBox
            // 
            this.skipBigFilesCheckBox.AutoSize = true;
            this.skipBigFilesCheckBox.Location = new System.Drawing.Point(44, 144);
            this.skipBigFilesCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.skipBigFilesCheckBox.Name = "skipBigFilesCheckBox";
            this.skipBigFilesCheckBox.Size = new System.Drawing.Size(89, 17);
            this.skipBigFilesCheckBox.TabIndex = 24;
            this.skipBigFilesCheckBox.Text = "Skip Big Files";
            this.skipBigFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // skipBigFilesLabel
            // 
            this.skipBigFilesLabel.AutoSize = true;
            this.skipBigFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skipBigFilesLabel.Location = new System.Drawing.Point(44, 179);
            this.skipBigFilesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skipBigFilesLabel.Name = "skipBigFilesLabel";
            this.skipBigFilesLabel.Size = new System.Drawing.Size(144, 17);
            this.skipBigFilesLabel.TabIndex = 25;
            this.skipBigFilesLabel.Text = "Skip files bigger than:";
            // 
            // skipBigFilesTextBox
            // 
            this.skipBigFilesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skipBigFilesTextBox.Location = new System.Drawing.Point(215, 176);
            this.skipBigFilesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.skipBigFilesTextBox.Name = "skipBigFilesTextBox";
            this.skipBigFilesTextBox.Size = new System.Drawing.Size(137, 23);
            this.skipBigFilesTextBox.TabIndex = 26;
            this.skipBigFilesTextBox.TextChanged += new System.EventHandler(this.skipBigFilesTextBox_TextChanged);
            this.skipBigFilesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skipBigFilesTextBox_KeyPress);
            // 
            // UoMLabel
            // 
            this.UoMLabel.AutoSize = true;
            this.UoMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UoMLabel.Location = new System.Drawing.Point(353, 179);
            this.UoMLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UoMLabel.Name = "UoMLabel";
            this.UoMLabel.Size = new System.Drawing.Size(37, 17);
            this.UoMLabel.TabIndex = 27;
            this.UoMLabel.Text = "(Mb)";
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(804, 5);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(90, 31);
            this.settingsButton.TabIndex = 29;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // textAfterNoNewLineCheckBox
            // 
            this.textAfterNoNewLineCheckBox.AutoSize = true;
            this.textAfterNoNewLineCheckBox.Location = new System.Drawing.Point(27, 599);
            this.textAfterNoNewLineCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAfterNoNewLineCheckBox.Name = "textAfterNoNewLineCheckBox";
            this.textAfterNoNewLineCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textAfterNoNewLineCheckBox.Size = new System.Drawing.Size(183, 17);
            this.textAfterNoNewLineCheckBox.TabIndex = 30;
            this.textAfterNoNewLineCheckBox.Text = "Do not start new line for After text";
            this.textAfterNoNewLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBeforeNoNewLineCheckBox
            // 
            this.textBeforeNoNewLineCheckBox.AutoSize = true;
            this.textBeforeNoNewLineCheckBox.Location = new System.Drawing.Point(27, 577);
            this.textBeforeNoNewLineCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBeforeNoNewLineCheckBox.Name = "textBeforeNoNewLineCheckBox";
            this.textBeforeNoNewLineCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBeforeNoNewLineCheckBox.Size = new System.Drawing.Size(192, 17);
            this.textBeforeNoNewLineCheckBox.TabIndex = 31;
            this.textBeforeNoNewLineCheckBox.Text = "Do not start new line for Before text";
            this.textBeforeNoNewLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBetweenNotNewLineCheckBox
            // 
            this.textBetweenNotNewLineCheckBox.AutoSize = true;
            this.textBetweenNotNewLineCheckBox.Location = new System.Drawing.Point(27, 621);
            this.textBetweenNotNewLineCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBetweenNotNewLineCheckBox.Name = "textBetweenNotNewLineCheckBox";
            this.textBetweenNotNewLineCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBetweenNotNewLineCheckBox.Size = new System.Drawing.Size(203, 17);
            this.textBetweenNotNewLineCheckBox.TabIndex = 32;
            this.textBetweenNotNewLineCheckBox.Text = "Do not start new line for Between text";
            this.textBetweenNotNewLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // mergeNextFileInSameLineCheckBox
            // 
            this.mergeNextFileInSameLineCheckBox.AutoSize = true;
            this.mergeNextFileInSameLineCheckBox.Location = new System.Drawing.Point(27, 643);
            this.mergeNextFileInSameLineCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mergeNextFileInSameLineCheckBox.Name = "mergeNextFileInSameLineCheckBox";
            this.mergeNextFileInSameLineCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mergeNextFileInSameLineCheckBox.Size = new System.Drawing.Size(202, 17);
            this.mergeNextFileInSameLineCheckBox.TabIndex = 33;
            this.mergeNextFileInSameLineCheckBox.Text = "Merge files without starting a new line";
            this.mergeNextFileInSameLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 669);
            this.Controls.Add(this.mergeNextFileInSameLineCheckBox);
            this.Controls.Add(this.textBetweenNotNewLineCheckBox);
            this.Controls.Add(this.textBeforeNoNewLineCheckBox);
            this.Controls.Add(this.textAfterNoNewLineCheckBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.UoMLabel);
            this.Controls.Add(this.skipBigFilesTextBox);
            this.Controls.Add(this.skipBigFilesLabel);
            this.Controls.Add(this.skipBigFilesCheckBox);
            this.Controls.Add(this.includeFilesInSubfoldersCheckBox);
            this.Controls.Add(this.clearAllSelectedFoldersButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.betweenTextBox);
            this.Controls.Add(this.betweenLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.afterTextBox);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.beforeTextBox);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.beforeLabel);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.selectedLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label beforeLabel;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RichTextBox beforeTextBox;
        private System.Windows.Forms.RichTextBox outputFileTextBox;
        private System.Windows.Forms.RichTextBox afterTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox betweenTextBox;
        private System.Windows.Forms.Label betweenLabel;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearAllSelectedFoldersButton;
        private System.Windows.Forms.CheckBox includeFilesInSubfoldersCheckBox;
        private System.Windows.Forms.CheckBox skipBigFilesCheckBox;
        private System.Windows.Forms.Label skipBigFilesLabel;
        private System.Windows.Forms.TextBox skipBigFilesTextBox;
        private System.Windows.Forms.Label UoMLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.CheckBox textAfterNoNewLineCheckBox;
        private System.Windows.Forms.CheckBox textBeforeNoNewLineCheckBox;
        private System.Windows.Forms.CheckBox textBetweenNotNewLineCheckBox;
        private System.Windows.Forms.CheckBox mergeNextFileInSameLineCheckBox;
    }
}

