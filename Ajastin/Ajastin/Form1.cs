using System.Diagnostics;
using System.Media;
using System;
using WMPLib;
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
            resetBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                minuuttiCB.Items.Add(i.ToString());
                sekunttiCB.Items.Add(i.ToString());
            }
            minuuttiCB.SelectedIndex = 0;
            sekunttiCB.SelectedIndex = 0;   
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            resetBT.Enabled = true;
            /*SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Marko\\Tempkoulu\\clocktick.wav";
            player.Play();*/
            if (ajastinLB.Text != "00:00")
            {
                string[] aika = ajastinLB.Text.Split(':');
                int min = int.Parse(aika[0]);
                int sek = int.Parse(aika[1]);
                kokonaisaika = (min * 60) + sek;
                //ajastinTM.Enabled = true;
            }
            else
            {
                int minuutti = int.Parse(minuuttiCB.SelectedItem.ToString());
                int sekuntti = int.Parse(sekunttiCB.SelectedItem.ToString());
                kokonaisaika = (minuutti * 60) + sekuntti;
            }
            ajastinTM.Enabled = true;
            ajastinTM.Start();
        }

        /*private void resetBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            resetBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            ajastinLB.Text = "00:00";
            player.Stop();
        }*/
        SoundPlayer player = new SoundPlayer();
        private void ajastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutti = kokonaisaika / 60;
                int sekuntti = kokonaisaika - (minuutti * 60);
                /*WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
                wplayer.URL = "C:\\Marko\\Tempkoulu\\tiktok.mp3";
                wplayer.controls.play();*/
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "C:\\Marko\\Tempkoulu\\clocktick.wav";
                player.Play();
                ajastinLB.Text = minuutti.ToString() + ":" + sekuntti.ToString();
            }
            else
            {
                ajastinTM.Stop();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "C:\\Marko\\Tempkoulu\\alert_siren.wav";
                player.Play();
                
                MessageBox.Show("Valmis!");
            }
        }

        private void pauseBT_Click(object sender, EventArgs e)
        {
            ajastinTM.Stop();
            startBT.Enabled = true;
            
        }

        private void resetBT_Click_1(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            resetBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTM.Enabled = false;
            ajastinLB.Text = "00:00";
            player.Stop();
        }
    }
}