namespace Harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeIkaBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.25) + " kuukautta";
            PaivinaLB.Text = erotus + " p‰iv‰‰";
            TunteinaLB.Text = (erotus * 24) + " tuntia";
            MinuutteinaLB.Text = (erotus * 24 * 60) + " minuuttia";
            SekuntteinaLB.Text = (erotus * 24 * 60 * 60) + " sekuntteina";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekuntteinaLB.Visible = true;

        } 
    }
}