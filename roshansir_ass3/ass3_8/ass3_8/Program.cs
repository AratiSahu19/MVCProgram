using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, b,count=1;
            Console.WriteLine("enter no of line");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no of integer in a line");
            b = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i< p;i++)
            {
                for(int j=1;j<= b;j++)
                {
                    Console.Write(count++);
                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}
