using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Music_Book_Index_Search
{
    public class MusicBookSearch
    {
        public event EventHandler MusicBooksChanged;


        public List<Tuple<string, string>> MusicBooks
        {
            get { return new List<Tuple<string, string>>(_musicBooks); }
            set
            {
                _musicBooks = new List<Tuple<string, string>>(value);
                OnMusicBooksChanged();
            }
        }
        public System.Collections.Specialized.StringCollection Favourites
        {
            get
            {
                return _favourites;
            }
            set
            {
                if (value == null)
                {
                    _favourites = new System.Collections.Specialized.StringCollection();
                }
                else
                {
                    _favourites = value;
                }
            }
        }


        private List<Tuple<string, string>> _musicBooks = new List<Tuple<string, string>>(); //csv, pdf filepath
        private List<SongItem> _index = new List<SongItem>();
        private System.Collections.Specialized.StringCollection _favourites = new System.Collections.Specialized.StringCollection();


        public void AddMusicBook(Tuple<string, string> filepair)
        {
            _musicBooks.Add(filepair);
            OnMusicBooksChanged();
        }
        public void RemoveMusicBook(Tuple<string, string> filepair)
        {
            _musicBooks.Remove(filepair);
            OnMusicBooksChanged();
        }

        public IEnumerable<SongItem> SearchMusicBooks(string searchedName)
        {
            if (String.IsNullOrEmpty(searchedName))
            {
                return _index;
            }
            searchedName = searchedName.ToLower();
            return _index.Where(song => song.Title.ToLower().Contains(searchedName));
        }

        public bool IsFavourite(string song)
        {
            return _favourites.Contains(song);
        }
        public void SetFavourite(string song, bool isFavorite)
        {
            if (isFavorite)
            {
                if (!_favourites.Contains(song))
                {
                    _favourites.Add(song);
                }
            }
            else
            {
                _favourites.Remove(song);
            }
        }


        void OnMusicBooksChanged()
        {
            _index.Clear();
            foreach (Tuple<string, string> filepair in _musicBooks)
            {
                var csvData = ProcessCsv(filepair.Item1);
                _index.AddRange(
                   csvData.Select(tuple => new SongItem(tuple.Item1, Path.GetFileNameWithoutExtension(filepair.Item1), filepair.Item2, tuple.Item2, tuple.Item3)));
            }
            _index.Sort();

            MusicBooksChanged?.Invoke(this, EventArgs.Empty);
        }

        private List<Tuple<string, int, int?>> ProcessCsv(string filepath, char delimiter = ',', char quoteCharacter = '\"', char quoteEscapeCharacter = '\"')
        {
            List<Tuple<string, int, int?>> result = new List<Tuple<string, int, int?>>();

            //TODO: Exception handling if filepath does not exist (Show dialog with folder of config file)
            using (NotVisualBasic.FileIO.CsvTextFieldParser parser = new NotVisualBasic.FileIO.CsvTextFieldParser(filepath))
            {
                parser.SetDelimiter(delimiter);
                parser.SetQuoteCharacter(quoteCharacter);
                parser.SetQuoteEscapeCharacter(quoteEscapeCharacter);

                while (!parser.EndOfData)
                {
                    var line = parser.ReadFields();

                    int startingPage = 0;
                    if (Int32.TryParse(line[1], out startingPage))
                    {
                        int endingPage = 0;
                        bool endingPageGiven = (line.Length > 2) && Int32.TryParse(line[2], out endingPage);
                        result.Add(new Tuple<string, int, int?>(line[0], startingPage, endingPageGiven ? (int?)endingPage : null));
                    }
                    else
                    {
                        Properties.Settings.Default.Log += $"The Song \"{line[0]}\" has no page number ({line[1]}, {line[2]})." + System.Environment.NewLine;
                    }
                }
            }
            Properties.Settings.Default.Save();
            return result;
        }
    }
}

public class SongItem : IComparable
{
    public SongItem(Tuple<string, string, string, int, int?> data)  //Title, music book name (csv title), pdf filepath, page start, page end 
    {
        Title = data.Item1;
        MusicBookName = data.Item2;
        PdfFilePath = data.Item3;
        PageStart = data.Item4;
        PageEnd = data.Item5;
    }
    public SongItem(string title, string musicBookName, string pdfFilePath, int pageStart, int? pageEnd)
    {
        Title = title;
        MusicBookName = musicBookName;
        PdfFilePath = pdfFilePath;
        PageStart = pageStart;
        PageEnd = pageEnd;
    }

    public string Title { get; private set; }
    public string MusicBookName { get; private set; }
    public string PdfFilePath { get; private set; }
    public int PageStart { get; private set; }
    public int? PageEnd { get; private set; }

    public string Location
    {
        get
        {
            string pages = "";
            if (PageEnd.HasValue)
            {
                pages = "-" + PageEnd;
            }
            return MusicBookName + " p." + PageStart + pages + "";
        }
    }

    public override string ToString()
    {
        return Title + " in " + Location;
    }

    public int CompareTo(object obj)
    {
        return ToString().CompareTo(obj.ToString());
    }
}
