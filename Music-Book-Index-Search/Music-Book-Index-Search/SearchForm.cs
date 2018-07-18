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
            this.FormClosing += SearchForm_FormClosing;

            Properties.Settings.Default.Log = "";
            Properties.Settings.Default.Save();

            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.MusicBooks))
            {
                _musicBookSearch.MusicBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tuple<string, string>>>(Properties.Settings.Default.MusicBooks);
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var tempString = Newtonsoft.Json.JsonConvert.SerializeObject(_musicBookSearch.MusicBooks);
            Properties.Settings.Default.MusicBooks = tempString;
            Properties.Settings.Default.Save();
        }

        OptionsForm _optionsForm;
        MusicBookSearch _musicBookSearch = new MusicBookSearch();

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
            foreach (var result in results)
            {
                resultsListBox.Items.Add(result);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowSearchResults();
        }
    }
}
