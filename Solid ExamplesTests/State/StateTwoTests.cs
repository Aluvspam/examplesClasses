using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid_Examples.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.State.Tests
{
    [TestClass()]
    public class StateTwoTests
    {
        [TestMethod()]
        public void CristiMathTest()
        {
            Assert.AreEqual(StateTwo.CristiMath(true, 2), 4);
        }
        [TestMethod()]
        public void CristiMathTest2()
        {
            Assert.AreEqual(StateTwo.CristiMath(true, 2), 4);
        }
        [TestMethod()]
        public void CristiMathTest3()
        {
            Assert.AreEqual(StateTwo.CristiMath(false, 2), 4);
        }
        [TestMethod()]
        public void CristiMathTest4()
        {
            Assert.AreEqual(StateTwo.CristiMath(false, 2), 4);
        }
    }
}