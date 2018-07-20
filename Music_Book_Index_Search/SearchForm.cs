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
                _listBoxItemMargin = 6;
            }

            Properties.Settings.Default.Log = "";
            Properties.Settings.Default.Save();

            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.MusicBooks))
            {
                _musicBookSearch.MusicBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tuple<string, string>>>(Properties.Settings.Default.MusicBooks);
            }
            ShowSearchResults();
        }

        private void SearchForm_SizeChanged(object sender, EventArgs e)
        {
            resultsListBox.Invalidate();
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
            SizeF detailsTextSize = e.Graphics.MeasureString(item.Details, resultsListBox.Font);

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
            SizeF detailsTextSize = e.Graphics.MeasureString(item.Details, resultsListBox.Font);

            //Draw content
            if (CalculateSplitLines(listBox, ref titleTextSize, ref detailsTextSize))
            {
                DrawString(e, item.Title, 
                    e.Bounds.Left + _listBoxItemMargin, 
                    e.Bounds.Top + _listBoxItemMargin);
                DrawString(e, item.Details,
                    e.Bounds.Right - _listBoxItemMargin - (int)detailsTextSize.Width,
                    e.Bounds.Top + _listBoxItemMargin);
            }
            else
            {
                DrawString(e, item.Title, 
                    e.Bounds.Left + _listBoxItemMargin, 
                    e.Bounds.Top + _listBoxItemMargin);
                DrawString(e, item.Details,
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
            Properties.Settings.Default.Save();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            if (_optionsForm == null)
            {
                _optionsForm = new OptionsForm();
                _optionsForm.MusicBookSearch = _musicBookSearch;
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

            var results = _musicBookSearch.SearchMusicBooks(searchTextBox.Text).Select(item => new SongItem { Data = item });
            foreach (SongItem result in results)
            {
                resultsListBox.Items.Add(result);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowSearchResults();
        }

        private void resultsListBox_DoubleClick(object sender, EventArgs e)
        {
            var selectedItemData = ((SongItem)resultsListBox.SelectedItem).Data;
            _pdfOpener.Open(selectedItemData.Item3, selectedItemData.Item4);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var asForm = System.Windows.Automation.AutomationElement.FromHandle(this.Handle);
        }
    }
}
