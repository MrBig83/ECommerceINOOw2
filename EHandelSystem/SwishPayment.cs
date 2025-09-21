using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class SwishPayment : Payment
    {
        public string phone;

        public SwishPayment(decimal amount, DateTime date, string phone)
        {
            this.amount = amount;
            this.date = date;
            this.phone = phone;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Swish payment...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Swish payment of {amount} kr on {date.ToShortDateString()} from {phone}");
        }
    }


}
