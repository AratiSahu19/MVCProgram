using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i, fact = 1;
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());
                for (i = 1; i <= num; i++)
                {
                    fact = fact * i;

                }
                Console.WriteLine("factorial=" + fact);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
