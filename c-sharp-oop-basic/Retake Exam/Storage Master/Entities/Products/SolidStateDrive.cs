using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class SolidStateDrive : Product
    {
        private const double DefaulthWeight = 0.2;

        public SolidStateDrive(double price)
            : base(price, DefaulthWeight)
        {
        }
    }
}
