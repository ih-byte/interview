using CodingTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var paymentCategories = GetAllCategories();
            cmBxCategory.ValueMember = "Id";
            cmBxCategory.DisplayMember = "Name";
            cmBxCategory.DataSource = paymentCategories;
        }

        private List<PaymentCategory> GetAllCategories()
        {
            List<PaymentCategory> paymentCategories = new List<PaymentCategory>
            {
                new PaymentCategory { Id = 0, Name = "---Select---" },
                new PaymentCategory { Id = 1, Name = "Physical Product" },
                new PaymentCategory { Id = 2, Name = "Book" },
                new PaymentCategory { Id = 3, Name = "New Membership" },
                new PaymentCategory { Id = 4, Name = "Upgrade Membership" },
                new PaymentCategory { Id = 5, Name = "Learning to Ski Video" }
            };
            return paymentCategories;
        }
    }
}
