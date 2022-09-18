using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    internal class Brand
    {
        public string brandName;
        public string name;
        public int price;
        public Brand(string brandName, string name, int price)
        {
            this.brandName = brandName;
            this.name = name;
            this.price = price;
        }   
        public Brand()
        {

        }
        public override string ToString()
        {
            return brandName + " " + name + " " + price;
        }
    }
}
