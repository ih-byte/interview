using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Membership : IMembership
    {
        public void ActivateMembership()
        {
            MessageBox.Show("New membership created");
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
