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
            MessageBox.Show("Slip generated");
        }
    }
}
