using Pankki;
namespace Testipankki
{
    [TestClass]
    public class Pankkitilitesti
    {
        [TestMethod]
        public void Otto_OikeallaSummalla_PaivitaSaldo()
        {
            double alkusaldo = 36.50;
            double ottoSumma = 4.40;
            double oletettu = 32.10;
            Pankkitili tili= new Pankkitili(" Jaakko Parantainen", alkusaldo);
            tili.Otto(ottoSumma);
            double todellinen = tili.Saldo;
            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut!");
        }
    }
}