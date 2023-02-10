using System.Diagnostics;
using System.Media;
using System;
namespace Ajastin
{
    public partial class ajastinFM : Form
    {
        public ajastinFM()
        {
            InitializeComponent();
        }
        private int kokonaisaika;
        private void ajastinFM_Load(object sender, EventArgs e)
        {
            stopBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                minuuttiCB.Items.Add(i.ToString());
                sekunttiCB.Items.Add(i.ToString());
            }
            minuuttiCB.SelectedIndex = 2;
            sekunttiCB.SelectedIndex = 0;   
        }

        private void minuuttiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sekunttiLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            int minuutti = Int32.Parse(minuuttiCB.SelectedItem.ToString());
            int sekuntti = Int32.Parse(sekunttiCB.SelectedItem.ToString());
            kokonaisaika = (minuutti * 60) + sekuntti;
            ajastinTM.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            ajastinLB.Text = "00:00";
            player.Stop();
        }
        SoundPlayer player = new SoundPlayer();
        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutti = kokonaisaika / 60;
                int sekuntti = kokonaisaika - (minuutti * 60);
                ajastinLB.Text = minuutti.ToString() + ":" + sekuntti.ToString();
            }
            else
            {
                ajastinTM.Stop();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "C:\\Marko\\Tempkoulu\\ring_dd.wav";
                player.Play();
                MessageBox.Show("Aika loppui!");
            }
        }

        private void pauseBT_Click(object sender, EventArgs e)
        {
            ajastinTM.Stop();
            startBT.Enabled = true;
        }
    }
}