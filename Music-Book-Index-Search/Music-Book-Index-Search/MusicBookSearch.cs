using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Music_Book_Index_Search
{
    public class MusicBookSearch
    {
        private List<Tuple<string, string>> _musicBooks = new List<Tuple<string, string>>(); //csv, pdf filepath
        private List<Tuple<string, string, string, int, int?>> _index = new List<Tuple<string, string, string, int, int?>>();//Title, music book name (csv title), pdf filepath, page start, page end 

        public List<Tuple<string, string>> MusicBooks
        {
            get { return new List<Tuple<string, string>>(_musicBooks); }
            set
            {
                _musicBooks =  new List<Tuple<string, string>>(value);
                OnMusicBooksChanged();
            }
        }

        public event EventHandler MusicBooksChanged;

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

        void OnMusicBooksChanged()
        {
            _index.Clear();
            foreach (Tuple<string, string> filepair in _musicBooks)
            {
                var csvData = ProcessCsv(filepair.Item1);
                _index.AddRange(
                   csvData.Select(tuple => new Tuple<string, string, string, int, int?>(tuple.Item1, Path.GetFileNameWithoutExtension(filepair.Item1), filepair.Item2, tuple.Item2, tuple.Item3)));
            }
            _index.Sort();

            MusicBooksChanged?.Invoke(this, EventArgs.Empty);
        }

        private List<Tuple<string, int, int?>> ProcessCsv(string filepath, char delimiter = ',', char quoteCharacter = '\"', char quoteEscapeCharacter = '\"')
        {
            List<Tuple<string, int, int?>> result = new List<Tuple<string, int, int?>>();
            using (var parser = new NotVisualBasic.FileIO.CsvTextFieldParser(filepath))
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

        public IEnumerable<Tuple<string, string, string, int, int?>> SearchMusicBooks(string name)
        {
            name = name.ToLower();
            foreach(var element in _index)
            {
                if (element.Item1.ToLower().Contains(name))
                {

                }
            }
            return _index.Where(item => item.Item1.ToLower().Contains(name));
        }
    }
}

public struct SongItem
{
    public Tuple<string, string, string, int, int?> Data { get; set; }
    public override string ToString()
    {
        return Data.Item1 + ", " + Data.Item2;
    }
}
