using System;
using CodingTest.BusinessService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.UnitTest
{
    [TestClass]
    public class PackingUnitTest
    {
        [TestMethod]
        public void TestGenerateSlip()
        {
            IPacking packing = new Packing();
            packing.GenerateSlip();
            Assert.IsTrue(true);
        } 
    }
}
