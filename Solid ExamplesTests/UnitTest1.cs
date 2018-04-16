using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid_Examples;

namespace Solid_ExamplesTests
{
    [TestClass]
    public class UnitTest1
    {
        Rectangle r = new Rectangle();
        [TestMethod]
        public void TestArea()
        {
            r.Height = 4;
            r.Width = 5;
            Assert.IsTrue((r.Width * r.Height) == 20);
        }
        //[TestMethod]
        //public void TestArea2()
        //{
        //    SquareGaby s = new SquareGaby();

        //    s.Height = 4;
        //    s.Width = 5;
        //    Assert.IsTrue((s.Width * s.Height) == 20);
        //}
    }
}
