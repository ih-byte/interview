using System;
using CodingTest.BusinessService;
using CodingTest.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTest.UnitTest
{
    [TestClass]
    public class PaymentUnitTest
    {
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
    }
}
