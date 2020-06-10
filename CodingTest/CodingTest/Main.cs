using CodingTest.BusinessService;
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
            lblTotalAmountVal.Text= "0.00";
        }

        private List<PaymentCategory> GetAllCategories()
        {
            List<PaymentCategory> paymentCategories = new List<PaymentCategory>
            {
                new PaymentCategory { Id = 0, Name = "---Select---", Type="" },
                new PaymentCategory { Id = 1, Name = "Physical Product", Type="Product" },
                new PaymentCategory { Id = 2, Name = "Book", Type="Product" },
                new PaymentCategory { Id = 3, Name = "New Membership", Type="Membership" },
                new PaymentCategory { Id = 4, Name = "Upgrade Membership", Type="Membership" },
                new PaymentCategory { Id = 5, Name = "Learning to Ski Video", Type="Product" }
            };
            return paymentCategories;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //These models objects will be intialized from earlier stage of the application
            ProductItem item = new ProductItem
            {
                ProductId = 1,
                ProductQuantity = 1,
                ProductUnitPrice = 100.00
            };

            dynamic category = cmBxCategory.SelectedItem;
            string categoryType = category.Type;
            if (category.Id==0)
            {
                MessageBox.Show("Please select one option");
            }
            else
            {
                if (categoryType.Equals("Product"))
                {
                    ProductAmountCalculator(item);
                }
                else if (categoryType.Equals("Membership"))
                {
                    MembershipAmountCalculator(item, category.Id);
                }
            }
        }

        private void ProductAmountCalculator(ProductItem item)
        {
            Product product = new Product();
            var totalAmount= product.CalculateAmount(item);
            product.GenerateSlip();
            lblTotalAmountVal.Text = String.Format("{0:0.00}", totalAmount); 
        }

        private void MembershipAmountCalculator(ProductItem item,int categoryId)
        {
            Membership membership = new Membership();
            if(categoryId == 3)
            {
                item.ProductUnitPrice = 1000.00;//for tesing purpose
                membership.ActivateMembership();
            }
            else if (categoryId == 4)
            {
                item.ProductUnitPrice = 500.00;//for tesing purpose
                membership.UpgradeMembership();
            }

            var totalAmount = membership.CalculateAmount(item);           
            lblTotalAmountVal.Text = String.Format("{0:0.00}", totalAmount);
        }
    }
}
