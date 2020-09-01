using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the value of x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value of y");
            y= Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("{0},{1} are in (+,+)first quadrant", x, y);
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("{0},{1} are in (-,+)second quadrant", x, y);
            }

            else if (x <0 && y < 0)
            {
                Console.WriteLine("{0},{1} are in (-,-)third quadrant", x, y);
            }

            else if(x > 0 && y < 0)
            {
                Console.WriteLine("{0},{1} are in (+,-)fourth quadrant", x, y);
            }
            Console.ReadKey();
        }
    }
}
