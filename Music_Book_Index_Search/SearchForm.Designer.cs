﻿namespace Music_Book_Index_Search
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.openPdfButton = new System.Windows.Forms.Button();
            this.favouriteCheckBox = new System.Windows.Forms.CheckBox();
            this.showFavoritesOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.searchBackingTrackButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(12, 39);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(457, 265);
            this.resultsListBox.TabIndex = 4;
            this.resultsListBox.SelectedIndexChanged += new System.EventHandler(this.resultsListBox_SelectedIndexChanged);
            this.resultsListBox.DoubleClick += new System.EventHandler(this.resultsListBox_DoubleClick);
            this.resultsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultsListBox_KeyDown);
            this.resultsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultsListBox_KeyPress);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(341, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsButton.Location = new System.Drawing.Point(417, 10);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(52, 23);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(359, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // openPdfButton
            // 
            this.openPdfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openPdfButton.Enabled = false;
            this.openPdfButton.Location = new System.Drawing.Point(417, 310);
            this.openPdfButton.Name = "openPdfButton";
            this.openPdfButton.Size = new System.Drawing.Size(52, 23);
            this.openPdfButton.TabIndex = 8;
            this.openPdfButton.Text = "Open";
            this.openPdfButton.UseVisualStyleBackColor = true;
            this.openPdfButton.Click += new System.EventHandler(this.openPdfButton_Click);
            // 
            // favouriteCheckBox
            // 
            this.favouriteCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.favouriteCheckBox.AutoSize = true;
            this.favouriteCheckBox.Enabled = false;
            this.favouriteCheckBox.Location = new System.Drawing.Point(344, 314);
            this.favouriteCheckBox.Name = "favouriteCheckBox";
            this.favouriteCheckBox.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.favouriteCheckBox.Size = new System.Drawing.Size(67, 17);
            this.favouriteCheckBox.TabIndex = 7;
            this.favouriteCheckBox.Text = "Favorite";
            this.favouriteCheckBox.UseVisualStyleBackColor = true;
            this.favouriteCheckBox.CheckedChanged += new System.EventHandler(this.favouriteCheckBox_CheckedChanged);
            // 
            // showFavoritesOnlyCheckBox
            // 
            this.showFavoritesOnlyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showFavoritesOnlyCheckBox.AutoSize = true;
            this.showFavoritesOnlyCheckBox.Location = new System.Drawing.Point(13, 314);
            this.showFavoritesOnlyCheckBox.Name = "showFavoritesOnlyCheckBox";
            this.showFavoritesOnlyCheckBox.Size = new System.Drawing.Size(118, 17);
            this.showFavoritesOnlyCheckBox.TabIndex = 5;
            this.showFavoritesOnlyCheckBox.Text = "Show favorites only";
            this.showFavoritesOnlyCheckBox.UseVisualStyleBackColor = true;
            this.showFavoritesOnlyCheckBox.CheckedChanged += new System.EventHandler(this.showFavoritesOnlyCheckBox_CheckedChanged);
            // 
            // searchBackingTrackButton
            // 
            this.searchBackingTrackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBackingTrackButton.Enabled = false;
            this.searchBackingTrackButton.Location = new System.Drawing.Point(196, 310);
            this.searchBackingTrackButton.Name = "searchBackingTrackButton";
            this.searchBackingTrackButton.Size = new System.Drawing.Size(142, 23);
            this.searchBackingTrackButton.TabIndex = 6;
            this.searchBackingTrackButton.Text = "Search backing track (YT)";
            this.searchBackingTrackButton.UseVisualStyleBackColor = true;
            this.searchBackingTrackButton.Click += new System.EventHandler(this.searchBackingTrackButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 345);
            this.Controls.Add(this.searchBackingTrackButton);
            this.Controls.Add(this.showFavoritesOnlyCheckBox);
            this.Controls.Add(this.favouriteCheckBox);
            this.Controls.Add(this.openPdfButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.resultsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Music Book Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button openPdfButton;
        private System.Windows.Forms.CheckBox favouriteCheckBox;
        private System.Windows.Forms.CheckBox showFavoritesOnlyCheckBox;
        private System.Windows.Forms.Button searchBackingTrackButton;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

