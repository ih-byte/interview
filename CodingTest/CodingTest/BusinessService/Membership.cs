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
            MessageBox.Show("New membership created");
        }

        public double CalculateAmount(ProductItem product)
        {
            MessageBox.Show("Calculate Total Amount");
            return 0;
        }

        public void SendMail()
        {
            MessageBox.Show("Email send to owner");
        }

        public void UpgradeMembership()
        {
            MessageBox.Show("Upgraded membership");
        }
    }
}
