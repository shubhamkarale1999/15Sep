using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    internal class InBetweenPrice
    {
        public static void Execution()
        {
            Console.WriteLine("Enetr Product Numbers");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("brand Name");
            Console.WriteLine("Name");
            Console.WriteLine("price");
            List<Brand> brands = new List<Brand>();
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Eter Details");
                    brands.Add(new Brand() { brandName = Console.ReadLine(), name = Console.ReadLine(), price = int.Parse(Console.ReadLine()) });
                }
                Console.WriteLine("Please Enter first value");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Second value");
                int j = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                var result=(from b in brands
                           where b.price >= k && b.price<=j
                           select b);
                Console.WriteLine("List bet"+k+" Product "+j+"As Below");
                foreach (var brand in result)
                {
                    Console.WriteLine(brand);
                }
                Console.ReadLine();
            }
        }
    }
}
