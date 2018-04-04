using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            Assert.IsTrue((new int[] {  3, 28, 29 }).SequenceEqual(DinglemouseRecursive.humanYearsCatYearsDogYears(3)));
        }
    }
}