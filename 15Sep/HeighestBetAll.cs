using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    internal class HeighestBetAll
    {
        public static void Execute()
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
               // Console.WriteLine("Please Enter Char");
               // string s = Console.ReadLine();
                var result = (from b in brands
                              orderby b.price descending
                              select b).FirstOrDefault();
                Console.WriteLine("Heighest Between All");
                //foreach (var brand in result)
                //{
                //    Console.WriteLine(brand);
                //}
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
