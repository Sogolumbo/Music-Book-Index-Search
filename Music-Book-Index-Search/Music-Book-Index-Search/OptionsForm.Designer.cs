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
            this.musicBookflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseCsvButton = new System.Windows.Forms.Button();
            this.openCsvFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.csvFilepathTextBox = new System.Windows.Forms.TextBox();
            this.pdfFilepathTextBox = new System.Windows.Forms.TextBox();
            this.choosePdfButton = new System.Windows.Forms.Button();
            this.addMusicBookButton = new System.Windows.Forms.Button();
            this.addMusicBookGroupBox = new System.Windows.Forms.GroupBox();
            this.addMusicBookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicBookflowLayoutPanel
            // 
            this.musicBookflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicBookflowLayoutPanel.AutoScroll = true;
            this.musicBookflowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.musicBookflowLayoutPanel.Name = "musicBookflowLayoutPanel";
            this.musicBookflowLayoutPanel.Size = new System.Drawing.Size(580, 462);
            this.musicBookflowLayoutPanel.TabIndex = 0;
            this.musicBookflowLayoutPanel.SizeChanged += new System.EventHandler(this.musicBookflowLayoutPanel_SizeChanged);
            // 
            // chooseCsvButton
            // 
            this.chooseCsvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseCsvButton.Location = new System.Drawing.Point(422, 17);
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
            this.csvFilepathTextBox.Size = new System.Drawing.Size(410, 20);
            this.csvFilepathTextBox.TabIndex = 4;
            // 
            // pdfFilepathTextBox
            // 
            this.pdfFilepathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfFilepathTextBox.Location = new System.Drawing.Point(6, 46);
            this.pdfFilepathTextBox.Name = "pdfFilepathTextBox";
            this.pdfFilepathTextBox.Size = new System.Drawing.Size(410, 20);
            this.pdfFilepathTextBox.TabIndex = 5;
            // 
            // choosePdfButton
            // 
            this.choosePdfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePdfButton.Location = new System.Drawing.Point(422, 43);
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
            this.addMusicBookButton.Location = new System.Drawing.Point(518, 17);
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
            this.addMusicBookGroupBox.Location = new System.Drawing.Point(12, 480);
            this.addMusicBookGroupBox.Name = "addMusicBookGroupBox";
            this.addMusicBookGroupBox.Size = new System.Drawing.Size(580, 72);
            this.addMusicBookGroupBox.TabIndex = 7;
            this.addMusicBookGroupBox.TabStop = false;
            this.addMusicBookGroupBox.Text = "Add Music Book";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(604, 564);
            this.Controls.Add(this.addMusicBookGroupBox);
            this.Controls.Add(this.musicBookflowLayoutPanel);
            this.Name = "OptionsForm";
            this.Text = "Options - Music Book Search";
            this.addMusicBookGroupBox.ResumeLayout(false);
            this.addMusicBookGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
    }
}