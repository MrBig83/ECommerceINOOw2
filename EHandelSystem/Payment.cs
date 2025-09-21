using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public abstract class Payment : IDisplayable
    {
        public decimal amount;
        public DateTime date;

        public abstract void ProcessPayment();
        public abstract void DisplayInfo();
    }

}
