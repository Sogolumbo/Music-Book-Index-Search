using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Book_Index_Search
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        public MusicBookSearch MusicBookSearch
        {
            get
            {
                return _musicBookSearch;
            }
            set
            {
                _musicBookSearch = value;
                _musicBookSearch.MusicBooksChanged += _musicBookSearch_MusicBooksChanged;
                RefreshMusicBookList();
            }
        }


        private bool _csvChosen;
        private bool _pdfChosen;
        int _previousWidth;


        private void _musicBookSearch_MusicBooksChanged(object sender, EventArgs e)
        {
            RefreshMusicBookList();
        }

        private void RefreshMusicBookList()
        {
            musicBookflowLayoutPanel.Controls.Clear();
            if (_musicBookSearch.MusicBooks.Count < 1)
            {
                musicBookflowLayoutPanel.Controls.Add(new Label()
                {
                    Text = "You haven't added any music books yet. Once you added one it will show up here.",
                    AutoSize = true
                });
            }
            else
            {
                foreach (var filepair in _musicBookSearch.MusicBooks)
                {
                    var item = new MusicBookItemUserControl()
                    {
                        Filepair = filepair,
                        Width = MusicBookItemWidth()
                    };
                    item.RemoveItem += Item_RemoveItem;
                    musicBookflowLayoutPanel.Controls.Add(item);
                }
            }
        }

        private int MusicBookItemWidth()
        {
            return musicBookflowLayoutPanel.Width - 15;
        }

        private void Item_RemoveItem(object sender, RemoveItemEventArgs e)
        {
            _musicBookSearch.RemoveMusicBook(e.Filepair);
        }

        private MusicBookSearch _musicBookSearch;

        private void chooseCsvButton_Click(object sender, EventArgs e)
        {
            if (openCsvFileDialog.ShowDialog() == DialogResult.OK)
            {
                csvFilepathTextBox.Text = openCsvFileDialog.FileName;
                _csvChosen = true;
                UpdateAddButton();
            }
        }

        private void choosePdfButton_Click(object sender, EventArgs e)
        {
            if (openPdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfFilepathTextBox.Text = openPdfFileDialog.FileName;
                _pdfChosen = true;
                UpdateAddButton();
            }
        }

        private void UpdateAddButton()
        {
            addMusicBookButton.Enabled = _csvChosen && _pdfChosen;
        }

        private void addMusicBookButton_Click(object sender, EventArgs e)
        {
            MusicBookSearch.AddMusicBook(new Tuple<string, string>(openCsvFileDialog.FileName, openPdfFileDialog.FileName));
            csvFilepathTextBox.Text = "";
            pdfFilepathTextBox.Text = "";
            _csvChosen = false;
            _pdfChosen = false;
            addMusicBookButton.Enabled = false;
        }

        private void musicBookflowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            if (Width != _previousWidth)
            {
                int itemWidth = MusicBookItemWidth();
                foreach (Control control in musicBookflowLayoutPanel.Controls)
                {
                    control.Width = itemWidth;
                }

                _previousWidth = Width;
            }
        }

        private void issuesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Sogolumbo/Music-Book-Index-Search");
        }
    }
}
