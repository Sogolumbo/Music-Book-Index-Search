namespace Music_Book_Index_Search
{
    partial class MusicBookItemUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.csvFileLabel = new System.Windows.Forms.Label();
            this.pdfFileLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(6, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "label1";
            // 
            // csvFileLabel
            // 
            this.csvFileLabel.AutoSize = true;
            this.csvFileLabel.Location = new System.Drawing.Point(6, 25);
            this.csvFileLabel.Name = "csvFileLabel";
            this.csvFileLabel.Size = new System.Drawing.Size(35, 13);
            this.csvFileLabel.TabIndex = 1;
            this.csvFileLabel.Text = "label2";
            // 
            // pdfFileLabel
            // 
            this.pdfFileLabel.AutoSize = true;
            this.pdfFileLabel.Location = new System.Drawing.Point(6, 38);
            this.pdfFileLabel.Name = "pdfFileLabel";
            this.pdfFileLabel.Size = new System.Drawing.Size(35, 13);
            this.pdfFileLabel.TabIndex = 2;
            this.pdfFileLabel.Text = "label3";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(345, 15);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // MusicBookItemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.pdfFileLabel);
            this.Controls.Add(this.csvFileLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MusicBookItemUserControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(407, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label csvFileLabel;
        private System.Windows.Forms.Label pdfFileLabel;
        private System.Windows.Forms.Button removeButton;
    }
}
