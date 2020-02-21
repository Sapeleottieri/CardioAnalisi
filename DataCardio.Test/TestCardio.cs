using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class TestCardio
    {
        [TestMethod]
        public void TestCardio1()
        {
            int età = 26;
            int asp = 194;
            int risp = DataCardio.CalcoloBattiti(età);
            Assert.AreEqual(asp, risp);
        }
        [TestMethod]
        public void TestAllenamento()
        {
            double BattitiAttuali = 165;
            double BattitiMax = 194;
            string asp = "Ti stai allenando bene!";
            string risp = DataCardio.Allenamento(BattitiAttuali, BattitiMax);
            Assert.AreEqual(asp, risp);
        }
        [TestMethod]
        public void TestFrequenzaCardiacaRiposo()
        {
            int battiti = 80;
            string asp = "normale";
            string risp = DataCardio.FrequenzaCardiacaRiposo(battiti);
            Assert.AreEqual(asp, risp);

        }
        [DataTestMethod]
        [DataRow("uomo",18,80,30,165,491.53)]
        [DataRow("donna", 18, 70, 30, 165, 455.57)]

        public void TestCalorieBruciate(string sesso, double anni, double peso, double tempo, double freq,double asp)
        {
            //string sesso = "uomo";
            //double anni = 18;
            //double peso = 80;
            //double freq = 165;
            //double tempo = 30;
            //double asp = 491.53;
            double risp =DataCardio.CalorieBruciate(sesso, anni, peso, tempo, freq);
            Assert.AreEqual(asp, risp);
        }
    }
}
