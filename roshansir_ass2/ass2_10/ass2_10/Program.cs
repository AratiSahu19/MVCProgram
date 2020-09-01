using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the specified value");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<= n;i++)
            {
                if(i%2==0)
                {
                    double square = i * i;
                    Console.WriteLine("square of {0}={1}", i, square);
                }
            }
            Console.ReadKey();
        }
    }
}
