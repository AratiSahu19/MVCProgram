using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            float w1, w2, avg;
            int item1, item2;

            Console.WriteLine("enter one items weight");
            w1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter second items weight");
            w2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter item1");
            item1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter item2");
            item2 = Convert.ToInt32(Console.ReadLine());
            avg = w1 * item1 + w2 * item2 / item1 + item2;
            Console.WriteLine("average of weight is" + avg);
            Console.ReadKey();             
        }
    }
}
