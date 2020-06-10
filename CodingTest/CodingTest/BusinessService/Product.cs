using CodingTest.Model;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Product : IPayment, IPacking
    {
        public double CalculateAmount(ProductItem product)
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Calculate Total Amount");
            return product.ProductQuantity * product.ProductUnitPrice;
        }

        public void GenerateSlip()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Slip generated");
        }
    }
}
