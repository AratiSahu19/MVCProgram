using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int res;

                Console.WriteLine("enter two numbers ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("number is " + res);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("nothing");

            }
            finally
            {
                Console.WriteLine("no errors");

            }
            Console.ReadKey();
            
        }
    }
}
