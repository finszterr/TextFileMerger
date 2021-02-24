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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.button4 = new System.Windows.Forms.Button();
            this.deleteSelectedFolderButton = new System.Windows.Forms.Button();
            this.includeFilesInSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.skipBigFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.skipBigFilesLabel = new System.Windows.Forms.Label();
            this.skipBigFilesTextBox = new System.Windows.Forms.TextBox();
            this.UoMLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedLabel.Location = new System.Drawing.Point(30, 19);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(181, 32);
            this.selectedLabel.TabIndex = 0;
            this.selectedLabel.Text = "Selected folder:";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.selectFolderButton.Location = new System.Drawing.Point(1072, 57);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(47, 84);
            this.selectFolderButton.TabIndex = 2;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mergeButton
            // 
            this.mergeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.mergeButton.Location = new System.Drawing.Point(519, 719);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(122, 44);
            this.mergeButton.TabIndex = 0;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // beforeLabel
            // 
            this.beforeLabel.AutoSize = true;
            this.beforeLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beforeLabel.Location = new System.Drawing.Point(30, 397);
            this.beforeLabel.Name = "beforeLabel";
            this.beforeLabel.Size = new System.Drawing.Size(284, 32);
            this.beforeLabel.TabIndex = 3;
            this.beforeLabel.Text = "Text before each text file:";
            this.toolTip.SetToolTip(this.beforeLabel, "[FileName] and [FilePath] strings will be replaced with the actual values.");
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.afterLabel.Location = new System.Drawing.Point(595, 397);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(263, 32);
            this.afterLabel.TabIndex = 5;
            this.afterLabel.Text = "Text after each text file:";
            this.toolTip.SetToolTip(this.afterLabel, "[FileName] and [FilePath] strings will be replaced with the actual values.");
            // 
            // outputFileButton
            // 
            this.outputFileButton.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.outputFileButton.Location = new System.Drawing.Point(1072, 329);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(47, 53);
            this.outputFileButton.TabIndex = 9;
            this.outputFileButton.Text = "...";
            this.outputFileButton.UseVisualStyleBackColor = true;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click);
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputFileLabel.Location = new System.Drawing.Point(30, 283);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(136, 32);
            this.outputFileLabel.TabIndex = 7;
            this.outputFileLabel.Text = "Output file:";
            // 
            // betweenLabel
            // 
            this.betweenLabel.AutoSize = true;
            this.betweenLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betweenLabel.Location = new System.Drawing.Point(30, 558);
            this.betweenLabel.Name = "betweenLabel";
            this.betweenLabel.Size = new System.Drawing.Size(251, 32);
            this.betweenLabel.TabIndex = 17;
            this.betweenLabel.Text = "Between the text files:";
            // 
            // beforeTextBox
            // 
            this.beforeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.beforeTextBox.Location = new System.Drawing.Point(36, 444);
            this.beforeTextBox.Name = "beforeTextBox";
            this.beforeTextBox.Size = new System.Drawing.Size(518, 99);
            this.beforeTextBox.TabIndex = 12;
            this.beforeTextBox.Text = "*** Beginning of [FileName]";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.outputFileTextBox.Location = new System.Drawing.Point(36, 329);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(1030, 53);
            this.outputFileTextBox.TabIndex = 13;
            this.outputFileTextBox.Text = "";
            // 
            // afterTextBox
            // 
            this.afterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.afterTextBox.Location = new System.Drawing.Point(601, 444);
            this.afterTextBox.Name = "afterTextBox";
            this.afterTextBox.Size = new System.Drawing.Size(518, 99);
            this.afterTextBox.TabIndex = 14;
            this.afterTextBox.Text = "*** End of [FileName]";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(355, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // betweenTextBox
            // 
            this.betweenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.betweenTextBox.Location = new System.Drawing.Point(36, 605);
            this.betweenTextBox.Name = "betweenTextBox";
            this.betweenTextBox.Size = new System.Drawing.Size(1083, 99);
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
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1030, 84);
            this.listBox1.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button4.Location = new System.Drawing.Point(1125, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 30);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteSelectedFolderButton
            // 
            this.deleteSelectedFolderButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteSelectedFolderButton.Location = new System.Drawing.Point(1125, 57);
            this.deleteSelectedFolderButton.Name = "deleteSelectedFolderButton";
            this.deleteSelectedFolderButton.Size = new System.Drawing.Size(66, 33);
            this.deleteSelectedFolderButton.TabIndex = 22;
            this.deleteSelectedFolderButton.Text = "x";
            this.deleteSelectedFolderButton.UseVisualStyleBackColor = true;
            this.deleteSelectedFolderButton.Click += new System.EventHandler(this.deleteSelectedFolderButton_Click);
            // 
            // includeFilesInSubfoldersCheckBox
            // 
            this.includeFilesInSubfoldersCheckBox.AutoSize = true;
            this.includeFilesInSubfoldersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includeFilesInSubfoldersCheckBox.Location = new System.Drawing.Point(240, 19);
            this.includeFilesInSubfoldersCheckBox.Name = "includeFilesInSubfoldersCheckBox";
            this.includeFilesInSubfoldersCheckBox.Size = new System.Drawing.Size(221, 24);
            this.includeFilesInSubfoldersCheckBox.TabIndex = 23;
            this.includeFilesInSubfoldersCheckBox.Text = "Include files in subfolders";
            this.includeFilesInSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // skipBigFilesCheckBox
            // 
            this.skipBigFilesCheckBox.AutoSize = true;
            this.skipBigFilesCheckBox.Location = new System.Drawing.Point(58, 177);
            this.skipBigFilesCheckBox.Name = "skipBigFilesCheckBox";
            this.skipBigFilesCheckBox.Size = new System.Drawing.Size(114, 21);
            this.skipBigFilesCheckBox.TabIndex = 24;
            this.skipBigFilesCheckBox.Text = "Skip Big Files";
            this.skipBigFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // skipBigFilesLabel
            // 
            this.skipBigFilesLabel.AutoSize = true;
            this.skipBigFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skipBigFilesLabel.Location = new System.Drawing.Point(58, 220);
            this.skipBigFilesLabel.Name = "skipBigFilesLabel";
            this.skipBigFilesLabel.Size = new System.Drawing.Size(170, 20);
            this.skipBigFilesLabel.TabIndex = 25;
            this.skipBigFilesLabel.Text = "Skip files bigger than:";
            // 
            // skipBigFilesTextBox
            // 
            this.skipBigFilesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skipBigFilesTextBox.Location = new System.Drawing.Point(287, 217);
            this.skipBigFilesTextBox.Name = "skipBigFilesTextBox";
            this.skipBigFilesTextBox.Size = new System.Drawing.Size(181, 26);
            this.skipBigFilesTextBox.TabIndex = 26;
            this.skipBigFilesTextBox.Text = "Setting";
            this.skipBigFilesTextBox.TextChanged += new System.EventHandler(this.skipBigFilesTextBox_TextChanged);
            this.skipBigFilesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skipBigFilesTextBox_KeyPress);
            // 
            // UoMLabel
            // 
            this.UoMLabel.AutoSize = true;
            this.UoMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UoMLabel.Location = new System.Drawing.Point(471, 220);
            this.UoMLabel.Name = "UoMLabel";
            this.UoMLabel.Size = new System.Drawing.Size(44, 20);
            this.UoMLabel.TabIndex = 27;
            this.UoMLabel.Text = "(Mb)";
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.settingsButton.Location = new System.Drawing.Point(1116, 13);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 38);
            this.settingsButton.TabIndex = 29;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 782);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.UoMLabel);
            this.Controls.Add(this.skipBigFilesTextBox);
            this.Controls.Add(this.skipBigFilesLabel);
            this.Controls.Add(this.skipBigFilesCheckBox);
            this.Controls.Add(this.includeFilesInSubfoldersCheckBox);
            this.Controls.Add(this.deleteSelectedFolderButton);
            this.Controls.Add(this.button4);
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
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deleteSelectedFolderButton;
        private System.Windows.Forms.CheckBox includeFilesInSubfoldersCheckBox;
        private System.Windows.Forms.CheckBox skipBigFilesCheckBox;
        private System.Windows.Forms.Label skipBigFilesLabel;
        private System.Windows.Forms.TextBox skipBigFilesTextBox;
        private System.Windows.Forms.Label UoMLabel;
        private System.Windows.Forms.Button settingsButton;
    }
}

