using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class InvoicePayment : Payment
    {
        public string invoiceNumber;

        public InvoicePayment(decimal amount, DateTime date, string invoiceNumber)
        {
            this.amount = amount;
            this.date = date;
            this.invoiceNumber = invoiceNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Generating invoice...");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Invoice {invoiceNumber} for {amount} kr created on {date.ToShortDateString()}");
        }
    }


}
