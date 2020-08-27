using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter numbers ");
            i = 10;
            while(i<20)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even no " + i);
                 
            }
            i++;
            Console.ReadKey();

        }
    }
}
