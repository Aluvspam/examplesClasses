using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Tests
{
    [TestClass()]
    public class DiceTests
    {
        [TestMethod()]
        public void RollDiceTest()
        {
            var d = new Dice();
            var x = d.RollDice();
            Assert.IsTrue(x[0] > 0);
            Assert.IsTrue(x[0] < 7);
            Assert.IsTrue(x[1] > 0);
            Assert.IsTrue(x[1] < 7);
        }
    }
}