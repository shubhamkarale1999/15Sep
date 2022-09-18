using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _15Sep
{
    internal class Lowestprice
    {
        public static void Lowprice()
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
               
                string s = Console.ReadLine();
               // var result =brands.Min(b => b.price).ToString();
                var result =(from b in brands    
                            orderby b.price ascending
                            select b).FirstOrDefault();
                Console.WriteLine("Lowest Price");
               /* foreach (var brand in result)
                {
                    Console.Write(brand);
                }
                Console.ReadLine();*/

                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
