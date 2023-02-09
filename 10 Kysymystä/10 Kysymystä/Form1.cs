namespace _10_Kysymystä
{
    public partial class kysymysFM : Form
    {
        string[] vastaukset = new string[10];
        string[] oikeat= new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D"};
        int laskuri = 0;
        int oikein = 0;
        public kysymysFM()
        {
            InitializeComponent();
            vastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                kysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen";
                laskuri++;
            }
            else
            {
                vastausLB.Text = "";
                vastausARB.Enabled= false;
                vastausBRB.Enabled = false;
                vastausCRB.Enabled = false;
                vastausDRB.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeita vastauksia on " + oikein;
                vastausLB.Visible= true;
            }
            tyhjaaVastaus();
        }
        private void tyhjaaVastaus()
        {
            if (vastausARB.Checked == true)
            {
                vastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if (vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if (vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }
        }

        private void kysymysFM_Load(object sender, EventArgs e)
        {

        }
    }
}