using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Packing : IPacking
    {
        public void GenerateSlip()
        {
            //the entire logic need to be added as per bussiness logic at later period
            MessageBox.Show("Slip generated");
        }
    }
}
