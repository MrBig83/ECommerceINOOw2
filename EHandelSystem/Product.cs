using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public abstract class Product : IDisplayable
    {
        private int id;
        public string name;
        public decimal price;
        public string category;

        public Product(int id, string name, decimal price, string category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public int GetId() { return id; }

        public abstract void DisplayInfo();
    }

}
