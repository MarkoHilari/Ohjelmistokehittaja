using System.IO;
using System.Windows.Forms;

namespace Suositut_nimet
{
    public partial class suositutNimetFM : Form
    {
        public suositutNimetFM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Marko/Tempkoulu/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Marko/Tempkoulu/tytot.txt");
            string nimi = vastausTB.Text;
            int laskurip = 0;
            int laskurit = 0;
            foreach (string poika in pojat)
            {
                if (nimi.ToUpper() == poika.ToUpper())
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string tytto in tytot)
            {
                if (nimi.ToUpper() == tytto.ToUpper())
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tytttöjen nimi";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimeäsi ei löytynyt suosittujen listalta, olet harvinainen";
                vastausLB.Visible = true;
            }
        }

        private void vastausTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void vastausTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                /*vastausLB.Text = "";
                vastausLB.Visible = false;
                string[] pojat = File.ReadAllLines("C:/Marko/Tempkoulu/pojat.txt");
                string[] tytot = File.ReadAllLines("C:/Marko/Tempkoulu/tytot.txt");
                string nimi = vastausTB.Text;
                int laskurip = 0;
                int laskurit = 0;
                foreach (string poika in pojat)
                {
                    if (nimi == poika)
                    {
                        vastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi";
                        vastausLB.Visible = true;
                    }
                    laskurip++;
                }
                foreach (string tytto in tytot)
                {
                    if (nimi == tytto)
                    {
                        vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tytttöjen nimi";
                        vastausLB.Visible = true;
                    }
                    laskurit++;
                }
                if (vastausLB.Visible == false)
                {
                    vastausLB.Text = "Nimeäsi ei löytynyt suosittujen listalta, olet harvinainen";
                    vastausLB.Visible = true;
                }*/
                button1_Click(sender, e);
            }
        }

        private void vastausTB_Enter(object sender, EventArgs e)
        {

        }
    }
}