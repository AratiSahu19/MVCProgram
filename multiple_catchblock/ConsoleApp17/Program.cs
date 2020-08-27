using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter 1st no :");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd no :");
                int n2 = int.Parse(Console.ReadLine());
                int k = n1 / n2;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("no is not in range");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("divide by zero error");
            }
            catch(Exception e)
            {
                Console.WriteLine("exception throw");
            }
            Console.ReadKey();
        }
    }
}
