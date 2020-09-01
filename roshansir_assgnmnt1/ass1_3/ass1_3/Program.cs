using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter three numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("greater no is=" + num1);

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("greater no is=" + num2);

            }
            else
                Console.WriteLine("greater no is=" + num3);
            Console.ReadKey();
        }
    }
}
