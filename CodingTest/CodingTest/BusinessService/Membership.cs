using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodingTest.Model;

namespace CodingTest.BusinessService
{
    public class Membership : IMembership, IPayment
    {
        public void ActivateMembership()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("New membership created");
        }

        public double CalculateAmount(ProductItem product)
        {
            MessageBox.Show("Total Amount Calculated");
            //the entire logic need to be added as per bussiness logic at later period
            return product.ProductQuantity*product.ProductUnitPrice;
        }

        public void SendMail()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Email send to owner");
        }

        public void UpgradeMembership()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Upgraded membership");
        }
    }
}
