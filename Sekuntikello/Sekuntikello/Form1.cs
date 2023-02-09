using System.Diagnostics;
using System.Windows.Forms;
namespace Sekuntikello
{
    public partial class sekuntiKelloFM : Form

    {
        //private Stopwatch sekuntiKello;
        Stopwatch sekuntiKello = new Stopwatch();
        public sekuntiKelloFM()
        {
            InitializeComponent();
        }   

        private void startBT_Click(object sender, EventArgs e)
        {
            sekuntiKello.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekuntiKello.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            sekuntiKello.Reset();
        }
        
        private void sekuntiKelloFM_Load(object sender, EventArgs e)
        {
            sekuntiKello = new Stopwatch();
        }
        private void aikaTM_Tick(object sender, EventArgs e)
        {
            kelloLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekuntiKello.Elapsed);
        }
    }
}