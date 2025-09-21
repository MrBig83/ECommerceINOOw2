using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class Customer : IDisplayable
    {
        private int id;
        public string name;
        public string email;

        public Customer(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public int GetId() { return id; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Customer {id}: {name}, {email}");
        }
    }

}
