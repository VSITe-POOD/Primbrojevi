using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Vsite.Pood
{
    [TestClass]
    public class TestGenerirajPrimBrojeve
    {
        [TestMethod]
        public void ZaArgument0MetodaVracaNizDuljine0()
        {
            Assert.AreEqual(0, Program.GenerirajPrimBrojeve(0).Length);
        } 
        [TestMethod]
        public void ZaArgument1MetodaVracaNizDuljine0()
        {
            Assert.AreEqual(0, Program.GenerirajPrimBrojeve(1).Length);
        }
        [TestMethod]
        public void ZaArgument2MetodaVracaNizDuljine1()
        {
            Assert.AreEqual(1, Program.GenerirajPrimBrojeve(2).Length);
        } 
        [TestMethod]
        public void ZaArgument2MetodaVracaNizUKojemJeSamoBroj2()
        {
            Assert.AreEqual(2, Program.GenerirajPrimBrojeve(2)[0]);
        }
        [TestMethod]
        public void ZaArgument100MetodaVracaNizDuljine25()
        {
            Assert.AreEqual(25, Program.GenerirajPrimBrojeve(100).Length);
        }
        [TestMethod]
        public void ZaArgument100MetodaVracaNizUKojemJeZadnjiClan97()
        {
            Assert.AreEqual(97, Program.GenerirajPrimBrojeve(100).Last());
        }
    }
}
