using System;

namespace findsquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num; 
                int sqr;
            Console.WriteLine("enter no");
            num = Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            Console.WriteLine("square=" + sqr);
        }
    }
}
