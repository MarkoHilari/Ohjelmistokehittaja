namespace NopanHeitto
{
    public partial class heitaNoppaFM : Form
    {
 

        public heitaNoppaFM()
        {
            InitializeComponent();
        }

        private void heitaBT_Click(object sender, EventArgs e)
        {
            teeNoppa(noppa01PB);
            teeNoppa(noppa02PB);
        }
        private void teeNoppa(PictureBox noppaBox)
        {
            
            Random satu = new Random();
            int noppa = satu.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    noppaBox.Image = Properties.Resources.dice01;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    noppaBox.Image = Properties.Resources.dice02;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    noppaBox.Image = Properties.Resources.dice03;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    noppaBox.Image = Properties.Resources.dice04;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    noppaBox.Image = Properties.Resources.dice05;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    noppaBox.Image = Properties.Resources.dice06;
                    noppaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void noppa01PB_Click(object sender, EventArgs e)
        {

        }
    }
}