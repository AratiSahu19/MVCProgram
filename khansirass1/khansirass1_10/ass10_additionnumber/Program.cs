using System;

namespace ass10_additionnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long num=0;
            long rem=0;
            Console.WriteLine("Enter 4 digit number");
            num = Convert.ToInt32(Console.ReadLine());
            Program.function1(num, rem);
            Console.ReadKey();
        }
        static void function1(long num, long rem)
        {
            long add = 0;

            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                add = add + rem;
            }
            Console.WriteLine("Addition of number is" + add);
        }
    }
}
