using System;

namespace palindrome
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int num1;
            int rev = 0, rem = 0;
            
            Console.WriteLine("enter a num");
            num1 = int.Parse(Console.ReadLine());
            int copynum = num1;
            while(num1!=0)
            {
                rem = num1 % 10;
                num1 = num1 / 10;
                rev = rev * 10 + rem;

            }
            if(copynum==rev)
            {
                Console.WriteLine("no is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

        }
    }
}
