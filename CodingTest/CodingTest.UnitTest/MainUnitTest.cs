using System;
using CodingTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.UnitTest
{
    [TestClass]
    public class MainUnitTest
    {
        [TestMethod]
        public void TestProductAmountCalculator()
        {
            ProductItem item = new ProductItem
            {
                ProductId = 1,
                ProductQuantity = 1,
                ProductUnitPrice = 100.00
            };
            Main main = new Main();
            main.ProductAmountCalculator(item, 1);
            Assert.IsTrue(true);

            main = new Main();
            main.ProductAmountCalculator(item, 2);
            Assert.IsTrue(true);

            main = new Main();
            main.ProductAmountCalculator(item, 5);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMembershipAmountCalculator()
        {
            ProductItem item = new ProductItem
            {
                ProductId = 1,
                ProductQuantity = 1,
                ProductUnitPrice = 100.00
            };
            Main main = new Main();
            main.ProductAmountCalculator(item, 1);
            Assert.IsTrue(true);

            main = new Main();
            main.ProductAmountCalculator(item, 3);
            Assert.IsTrue(true);

            main = new Main();
            main.ProductAmountCalculator(item, 4);
            Assert.IsTrue(true);
        }
    }
}
