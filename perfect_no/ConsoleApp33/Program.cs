using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i=1; i <num; i++)
            {
                if (num % i == 0)
                    s = s + i;
            }
            if (s == num)
                Console.WriteLine("perfect number " + s);
            else
                Console.WriteLine("not a perfect no " + s);
            Console.ReadKey();

        }
    }
}
