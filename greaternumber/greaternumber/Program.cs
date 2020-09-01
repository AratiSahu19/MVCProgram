using System;

namespace greaternumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("greater no is:" + n1);
            }
            else
            {
                Console.WriteLine("greater no is:" + n2);
            }
        }
    }
}
