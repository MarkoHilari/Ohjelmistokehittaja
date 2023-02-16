using System.IO;
namespace MuistioT17
{
    public partial class muistioFM : Form
    {
        string tiedostopolku = "";
        public muistioFM()
        {
            
            InitializeComponent();
        }

        private void postuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tektsiBX.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                tektsiBX.Text = "";
            }
            else
            {
                tektsiBX.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter="RikasTekstiFormaatti|*.rtf", ValidateNames = true, Multiselect=false})
            {
                if(atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        tektsiBX.Rtf = text.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                { Filter = "RikasTekstiFormaatti|.rtf", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.tektsiBX.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(tektsiBX.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "RikasTekstiFormaatti|.rtf", ValidateNames = true})
            {
                if (ttk.ShowDialog() == DialogResult.OK) 
                {
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(tektsiBX.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.Paste();
        }

        private void postaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            tektsiBX.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tektsiBX.SelectionBackColor = Color.Pink;
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true) 
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                tektsiBX.WordWrap= false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                tektsiBX.WordWrap= true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tektsiBX.Text, tektsiBX.Font, Brushes.Black, 12, 10);

        }

        private void tektsiBX_TextChanged(object sender, EventArgs e)
        {
            if(tektsiBX.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tieto = new tietoa();
            tieto.ShowDialog();
        }
    }
}