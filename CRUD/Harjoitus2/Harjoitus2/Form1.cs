namespace Harjoitus2
{
    public partial class Harjoitus2 : Form
    {
        public Harjoitus2()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            TulostusLB.Visible = true;
        }
    }
}