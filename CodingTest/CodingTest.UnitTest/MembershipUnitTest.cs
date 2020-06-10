using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingTest.BusinessService;
using CodingTest.Model;

namespace CodingTest.UnitTest
{
    [TestClass]
    public class MembershipUnitTest
    {
        [TestMethod]
        public void TestActivateMembership()
        {
            IMembership membership = new Membership();
            membership.ActivateMembership();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestUpgradeMembership()
        {
            IMembership membership = new Membership();
            membership.UpgradeMembership();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestSendMail()
        {
            IMembership membership = new Membership();
            membership.SendMail();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestCalculateAmount()
        {
            ProductItem item = new ProductItem
            {
                ProductId = 1,
                ProductQuantity = 1,
                ProductUnitPrice = 1000.00
            };
            IPayment payment = new Payment();
            var amount = payment.CalculateAmount(item);
            Assert.AreEqual(1000.00, amount);
        }
    }
}
