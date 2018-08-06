using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Book_Index_Search
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            FormClosing += SearchForm_FormClosing;
            resultsListBox.MeasureItem += ResultsListBox_MeasureItem;
            resultsListBox.DrawItem += ResultsListBox_DrawItem;
            SizeChanged += SearchForm_SizeChanged;

            if (TabletPcSupport.IsTabletMode)
            {
                Font = new Font(Font.FontFamily, 10);
                _listBoxItemMargin = 8;
            }

            Properties.Settings.Default.Log = "";
            Properties.Settings.Default.Save();

            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.MusicBooks))
            {
                _musicBookSearch.MusicBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tuple<string, string>>>(Properties.Settings.Default.MusicBooks);
            }
            _musicBookSearch.Favourites = Properties.Settings.Default.Favourites;
            ShowSearchResults();
        }


        OptionsForm _optionsForm;
        MusicBookSearch _musicBookSearch = new MusicBookSearch();
        PdfOpener _pdfOpener = new PdfOpener();
        int _listBoxItemMargin = 2;


        #region Listbox Graphics
        private void ResultsListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox listBox = sender as ListBox;
            SongItem item = (SongItem)listBox.Items[e.Index];

            // Measure the strings.
            SizeF titleTextSize = e.Graphics.MeasureString(item.Title, resultsListBox.Font);
            SizeF detailsTextSize = e.Graphics.MeasureString(item.Location, resultsListBox.Font);

            // Set the required size.
            if (CalculateSplitLines(listBox, ref titleTextSize, ref detailsTextSize))
            {
                //one line
                e.ItemHeight = (int)titleTextSize.Height + 2 * _listBoxItemMargin;
                e.ItemWidth = (int)(titleTextSize.Width + 8 + detailsTextSize.Height + 2 * _listBoxItemMargin);
            }
            else
            {
                //two lines
                e.ItemHeight = (int)(titleTextSize.Height + detailsTextSize.Height + 2 * _listBoxItemMargin);
                e.ItemWidth = (int)titleTextSize.Width + 2 * _listBoxItemMargin;
            }
        }

        private void ResultsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox listBox = sender as ListBox;
            if (e.Index < 0)
            {
                return;
            }

            SongItem item = (SongItem)listBox.Items[e.Index];

            // Draw the background.
            e.DrawBackground();

            // Measure the strings.
            SizeF titleTextSize = e.Graphics.MeasureString(item.Title, resultsListBox.Font);
            SizeF detailsTextSize = e.Graphics.MeasureString(item.Location, resultsListBox.Font);

            //Draw content
            if (CalculateSplitLines(listBox, ref titleTextSize, ref detailsTextSize))
            {
                DrawString(e, item.Title,
                    e.Bounds.Left + _listBoxItemMargin,
                    e.Bounds.Top + _listBoxItemMargin);
                DrawString(e, item.Location,
                    e.Bounds.Right - _listBoxItemMargin - (int)detailsTextSize.Width,
                    e.Bounds.Top + _listBoxItemMargin);
            }
            else
            {
                DrawString(e, item.Title,
                    e.Bounds.Left + _listBoxItemMargin,
                    e.Bounds.Top + _listBoxItemMargin);
                DrawString(e, item.Location,
                    e.Bounds.Right - _listBoxItemMargin - (int)detailsTextSize.Width,
                    e.Bounds.Top + _listBoxItemMargin + (int)titleTextSize.Height);
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        private bool CalculateSplitLines(ListBox listBox, ref SizeF titleTextSize, ref SizeF detailsTextSize)
        {
            return titleTextSize.Width + detailsTextSize.Width + 2 * _listBoxItemMargin <= listBox.ClientRectangle.Width;
        }

        private void DrawString(DrawItemEventArgs e, string text, int x, int y)
        {
            // See if the item is selected.
            if ((e.State & DrawItemState.Selected) ==
                DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.
                e.Graphics.DrawString(text,
                    resultsListBox.Font,
                    SystemBrushes.HighlightText,
                    x,
                    y);
            }
            else
            {
                // Not selected. Draw with ListBox's foreground color.
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(text,
                        resultsListBox.Font,
                        br,
                        x,
                        y);
                }
            }
        }
        #endregion

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var tempString = Newtonsoft.Json.JsonConvert.SerializeObject(_musicBookSearch.MusicBooks);
            Properties.Settings.Default.MusicBooks = tempString;
            Properties.Settings.Default.Favourites = _musicBookSearch.Favourites;
            Properties.Settings.Default.Save();
        }

        private void SearchForm_SizeChanged(object sender, EventArgs e)
        {
            resultsListBox.Invalidate();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (_optionsForm == null)
            {
                _optionsForm = new OptionsForm()
                {
                    MusicBookSearch = _musicBookSearch,
                    Font = this.Font
                };
                _optionsForm.FormClosed += OptionsForm_FormClosed;
                _optionsForm.Show();
            }
            else
            {
                if (_optionsForm.WindowState == FormWindowState.Minimized)
                {
                    _optionsForm.WindowState = FormWindowState.Normal;
                }
                _optionsForm.Focus();
            }
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _optionsForm = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ShowSearchResults();
        }

        private void ShowSearchResults()
        {
            resultsListBox.Items.Clear();

            IEnumerable<SongItem> results = _musicBookSearch.SearchMusicBooks(searchTextBox.Text);
            if (showFavoritesOnlyCheckBox.Checked)
            {
                results = results.Where(songItem => _musicBookSearch.Favourites.Contains(songItem.Title));
            }
            resultsListBox.Items.AddRange(results.ToArray());
            SetSelectedItemOptionsVisibility();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SearchAfterEveryKeyPress)
            {
                ShowSearchResults();
            }
        }

        private void resultsListBox_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedSong();
        }

        private void OpenSelectedSong()
        {
            var selectedItem = (SongItem)resultsListBox.SelectedItem;
            _pdfOpener.Open(selectedItem.PdfFilePath, selectedItem.PageStart);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(Handle);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ShowSearchResults();
                e.Handled = true;
            }
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedItemOptionsVisibility();
        }

        private void SetSelectedItemOptionsVisibility()
        {
            bool isAnyItemSelected = resultsListBox.SelectedItem != null;

            searchBackingTrackButton.Enabled = isAnyItemSelected;
            openPdfButton.Enabled = isAnyItemSelected;
            favouriteCheckBox.Enabled = isAnyItemSelected;

            if (favouriteCheckBox.Enabled)
            {
                var item = (SongItem)resultsListBox.SelectedItem;
                favouriteCheckBox.Checked = _musicBookSearch.IsFavourite(item.Title);
            }
        }

        private void favouriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var song = resultsListBox.SelectedItem as SongItem;
            _musicBookSearch.SetFavourite(song.Title, favouriteCheckBox.Checked);
        }

        private void showFavoritesOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowSearchResults();
        }

        private void openPdfButton_Click(object sender, EventArgs e)
        {
            OpenSelectedSong();
        }

        private void searchBackingTrackButton_Click(object sender, EventArgs e)
        {
            var song = resultsListBox.SelectedItem as SongItem;
            Process.Start(@"https://www.youtube.com/results?search_query=" + Uri.EscapeDataString(song.Title) + "+backing+track");
        }
    }
}
