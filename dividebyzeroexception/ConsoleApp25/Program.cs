using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int  r;
                Console.WriteLine("enter two nos");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                r = n1 / n2;
                Console.WriteLine("number is " + r);

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(" not divisible");

            }
            catch (Exception ee)
            {
                Console.WriteLine("execption caught");
            }
            Console.ReadKey();
        }
    }
}
