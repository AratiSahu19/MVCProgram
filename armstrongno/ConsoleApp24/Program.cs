using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0;

            Console.Write("Enter a number : ");

            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i = i / 10)

            {

                rem = i % 10;

                sum = sum + rem * rem * rem;

            }

            if (sum == num)

            {

                Console.Write("Entered number is an Armstrong number.");

            }

            else

                Console.Write("Entered number is not an Armstrong number.");

           
            Console.ReadKey();

        }
    }
}
