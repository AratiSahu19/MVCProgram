using System;
using System.Dynamic;

namespace primeno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 2, k = 1;
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            while (i <= num)
            {
                if (num % i == 0)
                {
                    k = k + 1;

                }
                i++;
            }
            if(k==2)
            {
                Console.WriteLine("prime no");

            }
            else
            {
                Console.WriteLine("not prime");
            }
            Console.ReadKey();
        }
    }
}
