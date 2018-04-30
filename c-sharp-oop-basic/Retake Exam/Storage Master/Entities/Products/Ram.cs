﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        private const double DefaulthWeight = 0.1;

        public Ram(double price)
            : base(price, DefaulthWeight)
        {
        }
    }
}
