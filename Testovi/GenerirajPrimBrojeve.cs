using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Vsite.Pood
{
    [TestClass]
    public class TestGenerirajPrimBrojeve
    {
        [TestMethod]
        public void ZaArgument0MetodaVraćaNizDuljine0()
        {
            var niz = Program.GenerirajPrimBrojeve(0);
            Assert.AreEqual(0, niz.Length);
        }
        
        [TestMethod]
        public void ZaArgument1MetodaVraćaNizDuljine0()
        {
            var niz = Program.GenerirajPrimBrojeve(1);
            Assert.AreEqual(0, niz.Length);
        }
        [TestMethod]
        public void ZaArgument2MetodaVraćaNizDuljine1()
        {
            var niz = Program.GenerirajPrimBrojeve(2);
            Assert.AreEqual(1, niz.Length);
        }        
        [TestMethod]
        public void ZaArgument2MetodaVraćaNizSaPrvimElementom2()
        {
            var niz = Program.GenerirajPrimBrojeve(2);
            Assert.AreEqual(2, niz[0]);
        }        
        [TestMethod]
        public void ZaArgument100MetodaVraćaNizDuljine25()
        {
            var niz = Program.GenerirajPrimBrojeve(100);
            Assert.AreEqual(25, niz.Length);
        }        
        [TestMethod]
        public void ZaArgument100MetodaVraćaNizSaZadnjimElementom97()
        {
            var niz = Program.GenerirajPrimBrojeve(100);
            Assert.AreEqual(97, niz.Last());
        }
    }
}
