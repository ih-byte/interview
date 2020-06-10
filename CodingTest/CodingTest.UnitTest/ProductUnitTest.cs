using System;
using CodingTest.BusinessService;
using CodingTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.UnitTest
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void TestGenerateSlip()
        {
            IPacking packing = new Packing();
            packing.GenerateSlip();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestCalculateAmount()
        {
            ProductItem item = new ProductItem
            {
                ProductId = 1,
                ProductQuantity = 1,
                ProductUnitPrice = 100.00
            };
            IPayment payment = new Payment();
            var amount = payment.CalculateAmount(item);
            Assert.AreEqual(100.00, amount);
        }

        [TestMethod]
        public void TestCommissionPayment()
        {
            double totalAmount = 500.00;
            ICommissionPayment payment = new Product();
            var amount = payment.CommissionPayment(totalAmount);
            Assert.AreEqual(10.00, amount);
        }
    }
}
