using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)

        {
            int res = 0;
           
            Console.WriteLine("Enter two numbers :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the choice :");
            char x = Convert.ToChar (Console.ReadLine());
            switch (x)
            {
                case '+':
                    res = num1 + num2;
                    Console.WriteLine("addition is  " + res);
                    break;
                case '-':
                    res = num1 - num2;
                    Console.WriteLine("substraction is " + res);
                    break;
                case '*':
                    res = num1 * num2;
                    Console.WriteLine("multiplication is " + res);
                    break;
                case '/':
                    res = num1 / num2;
                    Console.WriteLine("division is " + res);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            
                    Console.ReadKey();

            
        }
    }
}
