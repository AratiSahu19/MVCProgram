using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, r, s;
            int sum = 0;
            int sum2 = 0;
            Console.WriteLine("enter the 4 integer values");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            if (p % 2 == 0)
            {
                Console.WriteLine("p is even");
            }
            if (q > r && s > p)
            {

                sum = r + s;

                sum2 = p + q;  

                if (sum > sum2)
                {
                    Console.WriteLine("correct value");
                }
            }
            else
            {
                Console.WriteLine("wrong value");
            
            }
            Console.ReadKey();
        }
    
            
        }
   

    }

