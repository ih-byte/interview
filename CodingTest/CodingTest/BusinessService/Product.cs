using CodingTest.Model;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Product : IPayment, IPacking
    {
        public double CalculateAmount(ProductItem product)
        {
            MessageBox.Show("Calculate Total Amount");
            return 0;
        }

        public void GenerateSlip()
        {
            MessageBox.Show("Slip generated");
        }
    }
}
