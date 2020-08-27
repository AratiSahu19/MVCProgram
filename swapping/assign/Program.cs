using System;

namespace assign
{

    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20;
            //Console.WriteLine("enter two number");
            a = a + b;
             b= a - b;
            a = b- a;
            Console.WriteLine("enter swap value");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
           
            Console.ReadKey();

        }
    }
}
