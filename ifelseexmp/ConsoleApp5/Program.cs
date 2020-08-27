using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age ;
            int n = 18;
            Console.WriteLine("enter the age :");
            int a = Convert.ToInt32(Console.ReadLine());
           
            if (a >= 18)
                Console.WriteLine("the person can vote " + a);
            else
                Console.WriteLine(" not eligible to vote " + a);
            Console.ReadKey();
        }
    }
}
