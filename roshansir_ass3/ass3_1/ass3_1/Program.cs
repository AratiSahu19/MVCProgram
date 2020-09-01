using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter first no");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num2>num1)
            {
                Console.WriteLine("order of two no isascending order");
            }
            else
            {
                Console.WriteLine("order of two no is descending order");

            }
            Console.ReadKey();
        }

    }
}
