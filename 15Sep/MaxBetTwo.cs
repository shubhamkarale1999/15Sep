using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    internal class MaxBetTwo
    {
        public static void Execute()
        {
            Console.WriteLine("Enetr 2 Number of Product Details");
           // int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("brand Name");
            Console.WriteLine("Name");
            Console.WriteLine("price");
            List<Brand> brands = new List<Brand>();
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Eter Details");
                    brands.Add(new Brand() { brandName = Console.ReadLine(), name = Console.ReadLine(), price = int.Parse(Console.ReadLine()) });
                }
                //string s = Console.ReadLine();
                //var result =brands.Max(b => b.price).ToString();
                var result= (from b in brands
                             orderby b.price descending
                             select b).FirstOrDefault();
                Console.WriteLine();
                Console.WriteLine("Heighest price Between Two");
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
        
