using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double amnt;
            Console.WriteLine("enter the amount");
            amnt = Convert.ToDouble(Console.ReadLine());
            double rs10 = amnt / 10;
            double rs50 = amnt / 50;
            double rs100 = amnt / 100;
            double rs200 = amnt / 200;

            Console.WriteLine("no of 10 rs note=" + rs10);
            Console.WriteLine("no of 50 rs note=" + rs50);
            Console.WriteLine("no of 100 rs note=" + rs100);
            Console.WriteLine("no of 200 rs note=" + rs200);
            Console.ReadKey();
        }
    }
}
