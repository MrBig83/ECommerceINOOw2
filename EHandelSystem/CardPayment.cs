using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class CardPayment : Payment
    {
        public string cardNumber;

        public CardPayment(decimal amount, DateTime date, string cardNumber)
        {
            this.amount = amount;
            this.date = date;
            this.cardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing card payment...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Card payment of {amount} kr on {date.ToShortDateString()} with card {cardNumber}");
        }
    }


}
