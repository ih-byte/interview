﻿using CodingTest.Model;
using System;
using System.Windows.Forms;

namespace CodingTest.BusinessService
{
    public class Payment : IPayment
    {
        public double CalculateAmount(ProductItem product)
        {
            MessageBox.Show("Calculate Total Amount");
            return 0;
        }
    }
}
