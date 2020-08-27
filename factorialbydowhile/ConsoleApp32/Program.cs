using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("enter a no");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * num;
                num--;

            } while (num > 0);
            Console.WriteLine("factorial is " +fact );
        }
    }
}
