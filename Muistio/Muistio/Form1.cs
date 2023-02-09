using System.IO;
using System.Windows.Forms;

namespace Muistio
{
    public partial class muistioFM : Form
    {
        public muistioFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/Marko/Tempkoulu/Testi.txt");
            tekstiTB.Text = teksti;
        }

        private void muistiBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += tekstiTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Marko/Tempkoulu/Testi.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void muistiBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tekstiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                muistiBT_Click((object)sender, e);
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}