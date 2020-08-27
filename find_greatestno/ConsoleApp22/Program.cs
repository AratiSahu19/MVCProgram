using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter three numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num > num1 && num > num2)
                Console.WriteLine("greatest is" + num);
            else if (num1 > num && num1 > num2)
                Console.WriteLine("greatest is " + num1);
            else
                Console.WriteLine("greatest is " + num2);
            Console.ReadKey();
        }
    }
}
