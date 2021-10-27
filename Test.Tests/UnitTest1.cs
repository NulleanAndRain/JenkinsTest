using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 0;
            var actual = Biba.GetZero();

            Assert.AreEqual(actual, expected);
        }
    }
}
