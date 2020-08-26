using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int rem = 0;
            int rev = 0;
            Console.WriteLine("enter a number");
            num = int.Parse(Console.ReadLine());
            int cpynum = num;
            while(num!=0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev + (rem * rem * rem);

            }
            if(cpynum==rev)
            { 
                Console.WriteLine("no isarmstrong");
            }
            else
            {
                Console.WriteLine("not armstrong no");
            }
        }

    }
}
