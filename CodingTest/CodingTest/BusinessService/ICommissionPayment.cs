﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.BusinessService
{
    public interface ICommissionPayment
    {
        double CommissionPayment(double totalAmount);
    }
}
