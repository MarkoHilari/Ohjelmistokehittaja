using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Pankki
{
    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi = "";
        private double m_saldo;

        public Pankkitili() { }
        public Pankkitili(string nimi, double summa)
        {
            m_asiakkaanNimi = nimi;
            m_saldo = summa;
        }
        public double Saldo { get { return m_saldo; } }
        public string nimi { get { return m_asiakkaanNimi; } }

        public void Otto(double summa)
        {
            if (summa > m_saldo || summa < 0)
            {
                throw new ArgumentOutOfRangeException("Summa");
            }
            m_saldo -= summa;
        }
        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("Summa");
            }
            m_saldo += summa;
        }
        public static void Main()
        {
            Pankkitili pt = new Pankkitili(" Marko Hilari", 250.21);
            pt.Pano(652);
            pt.Otto(26);
            Console.WriteLine("Nymyinen saldo on {0} euroa", pt.Saldo);
        }
    }
}

    