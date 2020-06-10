using CodingTest.Model;
using System;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Payment : IPayment
    {
        public double CalculateAmount(ProductItem product)
        {
            MessageBox.Show("Total Amount Calculated");
            //the entire logic need to be added as per bussiness logic at later period
            return product.ProductQuantity * product.ProductUnitPrice;
        }
    }
}
