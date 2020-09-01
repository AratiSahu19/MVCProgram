using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double root;
            Console.WriteLine("enter the value of a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value of b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value of b");
            c = int.Parse(Console.ReadLine());

            int res = (b * b) - (4 * a * c);
            root = Math.Sqrt(res);
             if(root>0 && a!=0)
            {
                double x, y;
                x = (-b + root) / (2 * a);
                y = (-b - root) /( 2 * a);
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + y);
            }
            else
            {
                Console.WriteLine("equation is not valid");
            }
            Console.ReadKey();

        }
    }
}
