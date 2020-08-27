using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int rad;
           float  area = 0;
            Console.WriteLine("enter the radius :");
            rad = Convert.ToInt32(Console.ReadLine());
            area = 2 * 3.14f * rad;
            Console.WriteLine("area of circle is " + area);
            Console.ReadKey();
        }
    }
}
