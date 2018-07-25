using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Book_Index_Search
{
    class PdfOpener
    {
        public PdfCapablePrograms Program { get; set; }

        public void Open(string file, int page)
        {
            string commandLineArguments;
            switch (Program)
            {
                case PdfCapablePrograms.SumatraPdf:
                    commandLineArguments = "\"" + file + "\" -page " + page;
                    try
                    {
                        System.Diagnostics.Process.Start(Properties.Settings.Default.SumatraPdfFilePath, commandLineArguments);
                    }
                    catch(System.ComponentModel.Win32Exception)//sumatraPDF.exe not found
                    {
                        MessageBox.Show("The SumatraPDF.exe file could not be found. Please select the file.");
                        var dialog = new OpenFileDialog
                        {
                            Filter = "Executable files|*.exe|All files|*.*"
                        };
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            Properties.Settings.Default.SumatraPdfFilePath = dialog.FileName;
                            Properties.Settings.Default.Save();
                        }
                    }
                    break;
                default:
                    MessageBox.Show("The Program " + Program + " is not implemented (page " + page + " of " + file);
                    break;
            }
        }
    }

    enum PdfCapablePrograms
    {
        SumatraPdf
    }
}
