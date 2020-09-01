using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_roshansir4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num1 = ((num1 + num2) - num1);
            num2 = ((num1 + num2) - num2);
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
            Console.ReadKey();
        }
    }
}
