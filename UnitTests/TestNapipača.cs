using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{
    [TestClass]
    public class TestNapipača
    {
        [TestMethod]
        public void Napipač_ListaPoljaZaHorizontalniBrodDuljine3MoraBitiSadržavati15Polja()
        {
            Mreža m = new Mreža(1,7);
            const int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());

        }

       /*  [TestMethod]
        public void Napipač_ListaPoljaZaHorizontalniBrodDuljine3MoraBitiSadržavatiPoljaUOdređenomBroju()
        {
            Mreža m = new Mreža(1, 7);
            const int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());

        }*/
        



        [TestMethod]
        public void Napipač_ListaPoljaZaVertikalniBrodDuljine4MoraBitiSadržavati16Polja()
        {
            Mreža m = new Mreža(5, 2);
            const int duljinaBroda = 4;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(16, n.DajKandidateZaVertikalniBrod().Count());

        }
    }
}
