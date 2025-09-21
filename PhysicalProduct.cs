using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class PhysicalProduct : Product
    {
        public double weight;

        public PhysicalProduct(int id, string name, decimal price, string category, double weight)
            : base(id, name, price, category)
        {
            this.weight = weight;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[{GetId()}] {name} ({category}) - {price} kr, Weight: {weight} kg");
        }
    }

}
