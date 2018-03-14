using System;
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
    }
}
