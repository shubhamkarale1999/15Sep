using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Sep
{
    internal class SquareRoot
    {
        public static void Execution()
        {
                Console.Write("How many Numbers total: ");
                string sSize =Console.ReadLine();
                int i = Convert.ToInt32(sSize);
                int[] score = new int[i];

                for (int a = 0; a < i; a++)
                {
                    Console.Write("Please enter Number" + (a + 1) + " from 0 to 100: ");
               
                    string testArray = Console.ReadLine();
                    
                    int g = Convert.ToInt32(testArray);
                    score[a] = g;
                  //  MyExe(score);
                }
                var result = from obj in score
                             let SqrNo = obj*obj
                             select SqrNo;
                Console.WriteLine("Sqr of Above Numbers");
                foreach (var item in result)
                {
                    Console.WriteLine("{0} ",item);
                }
                Console.ReadLine();
        }
    }
}
