using CodingTest.Model;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Product : IPayment, IPacking, ICommissionPayment
    {
        public double CalculateAmount(ProductItem product)
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Total Amount Calculated");
            return product.ProductQuantity * product.ProductUnitPrice;
        }

        public double CommissionPayment(double totalAmount)
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Commission Amount Calculated for Agent");
            return totalAmount * 0.02; //for testing considered 2% commission on total amount
        }

        public void GenerateSlip()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Slip generated");
        }

    }
}
