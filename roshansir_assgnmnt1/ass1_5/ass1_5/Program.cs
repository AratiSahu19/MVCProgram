using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            float res;
            Console.WriteLine("enter the  x co-ordinates of first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  y co-ordinates of first point");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  x co-ordinates of second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  y co-ordinates of second point");
            y2 = Convert.ToInt32(Console.ReadLine());
            res = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
            double dis=Math.Sqrt(res);
            Console.WriteLine("distance between two co-ordinate=" + dis);

            Console.ReadKey();
        }
    }
}
