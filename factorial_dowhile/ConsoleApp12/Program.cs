using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine ("enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            do
            {
                fact = fact * num;
                num--;
            } while (num > 0);
            Console.WriteLine(" factorial is :" + fact);
            Console.ReadKey();

        }
    }
}
