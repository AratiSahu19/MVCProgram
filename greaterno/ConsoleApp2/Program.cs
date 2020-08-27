using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter 2 numbers ");
            int n1= Convert.ToInt32(Console.ReadLine());
            int n2= Convert.ToInt32(Console.ReadLine());
            if (n1>n2)
                Console.WriteLine("greatest number is = " + n1 );
            else
                Console.WriteLine("greatest number is = " + n2 );
            Console.ReadKey();
        }
    }
}
