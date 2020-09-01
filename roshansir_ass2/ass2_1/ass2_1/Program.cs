using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 10)
            {
                Console.WriteLine("{0} is between o to 10" ,+ num);
            }
            else if (num >= 11 && num <= 20)
            {
                Console.WriteLine("{0} is between 11 to 20" ,+ num);
            }
            else if (num >= 21 && num <= 30)
            {
                Console.WriteLine("{0} is between 21 to 30" ,+ num);
            }
            else if (num >= 31 && num <= 40)
            {
                Console.WriteLine("{0} is between  31 to 40", + num);
            }
            else if (num >= 41 && num <= 50)
            {
                Console.WriteLine("{0} is between 41 to 50", + num);
            }
            else if (num >= 51 && num <= 60)
            {
                Console.WriteLine("{0} is between 51 to 60", + num);
            }
            else if (num >= 61 && num <= 70)
            {
                Console.WriteLine("{0} is between 61 to 70", + num);
            }
            else if (num >= 71 && num <= 80)
            {
                Console.WriteLine("{0} is between 71 to 80", + num);
            }
            else
                Console.WriteLine("error, please enter a valid no");
            Console.ReadKey();
        }
    }
}
