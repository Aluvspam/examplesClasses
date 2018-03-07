using Microsoft.VisualStudio.TestTools.UnitTesting;
using DingleMouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingleMouse.Tests
{
    [TestClass()]
    public class DinglemouseRecursiveTests
    {
        [TestMethod()]
        public void CatYearsTest()
        {
            Assert.AreEqual(15, DinglemouseRecursive.CatYears(1));
        }

        [TestMethod()]
        public void DogYearsTest()
        {
            Assert.AreEqual(24, DinglemouseRecursive.DogYears(2));
        }

        [TestMethod()]
        public void humanYearsCatYearsDogYearsTest()
        {
            Assert.IsTrue((new int[] {  , 28, 29 }).SequenceEqual(DinglemouseRecursive.humanYearsCatYearsDogYears(3)));
        }
    }
}