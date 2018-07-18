using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Book_Index_Search
{
    public partial class MusicBookItemUserControl : UserControl
    {
        public MusicBookItemUserControl()
        {
            InitializeComponent();
            var titleFont = new Font(Font.FontFamily, Font.Size * 1.1f, Font.Style);
            titleLabel.Font = titleFont;
        }

        public event EventHandler<RemoveItemEventArgs> RemoveItem;

        private Tuple<string, string> _filepair;

        public Tuple<string, string> Filepair
        {
            get { return _filepair; }
            set
            {
                _filepair = value;
                csvFileLabel.Text = value.Item1;
                titleLabel.Text = Path.GetFileNameWithoutExtension(value.Item1);
                pdfFileLabel.Text = value.Item2;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveItem?.Invoke(this, new RemoveItemEventArgs(_filepair));
        }
    }

    public class RemoveItemEventArgs : EventArgs
    {
        public RemoveItemEventArgs(Tuple<string, string> filepair)
        {
            Filepair = filepair;
        }
        public Tuple<string, string> Filepair { private set; get; }
    }
}
