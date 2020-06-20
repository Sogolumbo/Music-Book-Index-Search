namespace Music_Book_Index_Search
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.musicBookflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseCsvButton = new System.Windows.Forms.Button();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.csvFilepathTextBox = new System.Windows.Forms.TextBox();
            this.pdfFilepathTextBox = new System.Windows.Forms.TextBox();
            this.choosePdfButton = new System.Windows.Forms.Button();
            this.addMusicBookButton = new System.Windows.Forms.Button();
            this.addMusicBookGroupBox = new System.Windows.Forms.GroupBox();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.issuesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchOnKeyPressCheckBox = new System.Windows.Forms.CheckBox();
            this.appDataPathButton = new System.Windows.Forms.Button();
            this.musicBooksListGroupBox = new System.Windows.Forms.GroupBox();
            this.shortcutLabel = new System.Windows.Forms.Label();
            this.addMusicBookGroupBox.SuspendLayout();
            this.musicBooksListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicBookflowLayoutPanel
            // 
            this.musicBookflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBookflowLayoutPanel.AutoScroll = true;
            this.musicBookflowLayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.musicBookflowLayoutPanel.Name = "musicBookflowLayoutPanel";
            this.musicBookflowLayoutPanel.Size = new System.Drawing.Size(457, 421);
            this.musicBookflowLayoutPanel.TabIndex = 0;
            this.musicBookflowLayoutPanel.SizeChanged += new System.EventHandler(this.musicBookflowLayoutPanel_SizeChanged);
            // 
            // chooseCsvButton
            // 
            this.chooseCsvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCsvButton.Location = new System.Drawing.Point(311, 17);
            this.chooseCsvButton.Name = "chooseCsvButton";
            this.chooseCsvButton.Size = new System.Drawing.Size(90, 23);
            this.chooseCsvButton.TabIndex = 3;
            this.chooseCsvButton.Text = "Select index file";
            this.chooseCsvButton.UseVisualStyleBackColor = true;
            this.chooseCsvButton.Click += new System.EventHandler(this.chooseCsvButton_Click);
            // 
            // openCsvFileDialog
            // 
            this.openCsvFileDialog.DefaultExt = "csv";
            this.openCsvFileDialog.FileName = "index.csv";
            this.openCsvFileDialog.Filter = "Csv files|*.csv|All files|*.*";
            this.openCsvFileDialog.Title = "Select index file";
            // 
            // openPdfFileDialog
            // 
            this.openPdfFileDialog.DefaultExt = "pdf";
            this.openPdfFileDialog.FileName = "music book.pdf";
            this.openPdfFileDialog.Filter = "Pdf files|*.pdf|All files|*.*";
            this.openPdfFileDialog.Title = "Select pdf file";
            // 
            // csvFilepathTextBox
            // 
            this.csvFilepathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csvFilepathTextBox.Location = new System.Drawing.Point(6, 20);
            this.csvFilepathTextBox.Name = "csvFilepathTextBox";
            this.csvFilepathTextBox.Size = new System.Drawing.Size(299, 20);
            this.csvFilepathTextBox.TabIndex = 4;
            // 
            // pdfFilepathTextBox
            // 
            this.pdfFilepathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfFilepathTextBox.Location = new System.Drawing.Point(6, 46);
            this.pdfFilepathTextBox.Name = "pdfFilepathTextBox";
            this.pdfFilepathTextBox.Size = new System.Drawing.Size(299, 20);
            this.pdfFilepathTextBox.TabIndex = 5;
            // 
            // choosePdfButton
            // 
            this.choosePdfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePdfButton.Location = new System.Drawing.Point(311, 43);
            this.choosePdfButton.Name = "choosePdfButton";
            this.choosePdfButton.Size = new System.Drawing.Size(90, 23);
            this.choosePdfButton.TabIndex = 3;
            this.choosePdfButton.Text = "Select pdf file";
            this.choosePdfButton.UseVisualStyleBackColor = true;
            this.choosePdfButton.Click += new System.EventHandler(this.choosePdfButton_Click);
            // 
            // addMusicBookButton
            // 
            this.addMusicBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMusicBookButton.Enabled = false;
            this.addMusicBookButton.Location = new System.Drawing.Point(407, 17);
            this.addMusicBookButton.Name = "addMusicBookButton";
            this.addMusicBookButton.Size = new System.Drawing.Size(56, 49);
            this.addMusicBookButton.TabIndex = 6;
            this.addMusicBookButton.Text = "Add";
            this.addMusicBookButton.UseVisualStyleBackColor = true;
            this.addMusicBookButton.Click += new System.EventHandler(this.addMusicBookButton_Click);
            // 
            // addMusicBookGroupBox
            // 
            this.addMusicBookGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMusicBookGroupBox.Controls.Add(this.csvFilepathTextBox);
            this.addMusicBookGroupBox.Controls.Add(this.addMusicBookButton);
            this.addMusicBookGroupBox.Controls.Add(this.chooseCsvButton);
            this.addMusicBookGroupBox.Controls.Add(this.pdfFilepathTextBox);
            this.addMusicBookGroupBox.Controls.Add(this.choosePdfButton);
            this.addMusicBookGroupBox.Location = new System.Drawing.Point(12, 491);
            this.addMusicBookGroupBox.Name = "addMusicBookGroupBox";
            this.addMusicBookGroupBox.Size = new System.Drawing.Size(469, 72);
            this.addMusicBookGroupBox.TabIndex = 7;
            this.addMusicBookGroupBox.TabStop = false;
            this.addMusicBookGroupBox.Text = "Add Music Book";
            // 
            // issuesLabel
            // 
            this.issuesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.issuesLabel.AutoSize = true;
            this.issuesLabel.Location = new System.Drawing.Point(15, 566);
            this.issuesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.issuesLabel.Name = "issuesLabel";
            this.issuesLabel.Size = new System.Drawing.Size(267, 13);
            this.issuesLabel.TabIndex = 8;
            this.issuesLabel.Text = "Do you have any thoughts or issues with this program? ";
            // 
            // issuesLinkLabel
            // 
            this.issuesLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.issuesLinkLabel.AutoSize = true;
            this.issuesLinkLabel.Location = new System.Drawing.Point(282, 566);
            this.issuesLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.issuesLinkLabel.Name = "issuesLinkLabel";
            this.issuesLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.issuesLinkLabel.TabIndex = 9;
            this.issuesLinkLabel.TabStop = true;
            this.issuesLinkLabel.Text = "Go to the project page";
            this.issuesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.issuesLinkLabel_LinkClicked);
            // 
            // searchOnKeyPressCheckBox
            // 
            this.searchOnKeyPressCheckBox.AutoSize = true;
            this.searchOnKeyPressCheckBox.Checked = true;
            this.searchOnKeyPressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchOnKeyPressCheckBox.Location = new System.Drawing.Point(12, 13);
            this.searchOnKeyPressCheckBox.Name = "searchOnKeyPressCheckBox";
            this.searchOnKeyPressCheckBox.Size = new System.Drawing.Size(256, 17);
            this.searchOnKeyPressCheckBox.TabIndex = 10;
            this.searchOnKeyPressCheckBox.Text = "Search after every key press (resource-intensive)";
            this.searchOnKeyPressCheckBox.UseVisualStyleBackColor = true;
            this.searchOnKeyPressCheckBox.CheckedChanged += new System.EventHandler(this.searchOnKeyPressCheckBox_CheckedChanged);
            // 
            // appDataPathButton
            // 
            this.appDataPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appDataPathButton.Location = new System.Drawing.Point(406, 9);
            this.appDataPathButton.Name = "appDataPathButton";
            this.appDataPathButton.Size = new System.Drawing.Size(75, 23);
            this.appDataPathButton.TabIndex = 11;
            this.appDataPathButton.Text = "Lost Data...";
            this.appDataPathButton.UseVisualStyleBackColor = true;
            this.appDataPathButton.Click += new System.EventHandler(this.appDataPathButton_Click);
            // 
            // musicBooksListGroupBox
            // 
            this.musicBooksListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBooksListGroupBox.Controls.Add(this.musicBookflowLayoutPanel);
            this.musicBooksListGroupBox.Location = new System.Drawing.Point(12, 39);
            this.musicBooksListGroupBox.Name = "musicBooksListGroupBox";
            this.musicBooksListGroupBox.Size = new System.Drawing.Size(469, 446);
            this.musicBooksListGroupBox.TabIndex = 12;
            this.musicBooksListGroupBox.TabStop = false;
            this.musicBooksListGroupBox.Text = "Music Books";
            // 
            // shortcutLabel
            // 
            this.shortcutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shortcutLabel.AutoSize = true;
            this.shortcutLabel.Location = new System.Drawing.Point(15, 585);
            this.shortcutLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.shortcutLabel.Name = "shortcutLabel";
            this.shortcutLabel.Size = new System.Drawing.Size(237, 39);
            this.shortcutLabel.TabIndex = 13;
            this.shortcutLabel.Text = "Shortcuts for the main program: \r\nAlt + F: Add/remove selected song from favorite" +
    "s\r\nCtrl + F: Move focus to the search text box.";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(493, 633);
            this.Controls.Add(this.shortcutLabel);
            this.Controls.Add(this.musicBooksListGroupBox);
            this.Controls.Add(this.appDataPathButton);
            this.Controls.Add(this.searchOnKeyPressCheckBox);
            this.Controls.Add(this.issuesLinkLabel);
            this.Controls.Add(this.issuesLabel);
            this.Controls.Add(this.addMusicBookGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 241);
            this.Name = "OptionsForm";
            this.Text = "Options - Music Book Search by Sogolumbo";
            this.addMusicBookGroupBox.ResumeLayout(false);
            this.addMusicBookGroupBox.PerformLayout();
            this.musicBooksListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel musicBookflowLayoutPanel;
        private System.Windows.Forms.Button chooseCsvButton;
        private System.Windows.Forms.OpenFileDialog openCsvFileDialog;
        private System.Windows.Forms.OpenFileDialog openPdfFileDialog;
        private System.Windows.Forms.TextBox csvFilepathTextBox;
        private System.Windows.Forms.TextBox pdfFilepathTextBox;
        private System.Windows.Forms.Button choosePdfButton;
        private System.Windows.Forms.Button addMusicBookButton;
        private System.Windows.Forms.GroupBox addMusicBookGroupBox;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.LinkLabel issuesLinkLabel;
        private System.Windows.Forms.CheckBox searchOnKeyPressCheckBox;
        private System.Windows.Forms.Button appDataPathButton;
        private System.Windows.Forms.GroupBox musicBooksListGroupBox;
        private System.Windows.Forms.Label shortcutLabel;
    }
}