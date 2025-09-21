using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class Order : IDisplayable
    {
        public int id;
        public DateTime orderDate;
        public Customer customer;
        public Product product;
        public int quantity;
        public Payment payment; // <-- nytt

        public Order(int id, DateTime orderDate, Customer customer, Product product, int quantity)
        {
            this.id = id;
            this.orderDate = orderDate;
            this.customer = customer;
            this.product = product;
            this.quantity = quantity;
        }

        public decimal CalculateTotal()
        {
            return product.price * quantity;
        }

        public void AddPayment(Payment payment)
        {
            this.payment = payment;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("-- Order & Payment --");
            Console.WriteLine($"Order {id} ({orderDate.ToShortDateString()})");
            Console.WriteLine($"Customer: {customer.name}");
            product.DisplayInfo();
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total: {CalculateTotal()} kr");

            if (payment != null)
            {
                Console.WriteLine("-- Payment info --");
                payment.DisplayInfo();
            }
        }
    }


}
