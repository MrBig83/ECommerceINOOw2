using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceINOOw2
{
    public class DigitalProduct : Product
    {
        public double filesize;

        public DigitalProduct(int id, string name, decimal price, string category, double filesize)
            : base(id, name, price, category)
        {
            this.filesize = filesize;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[{GetId()}] {name} ({category}) - {price} kr, Size: {filesize} MB");
        }
    }

}
