using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i, j, k;
                Console.WriteLine("enter i and j");
                i = int.Parse(Console.ReadLine());
                j = int.Parse(Console.ReadLine());
                k = i / j;
                Console.WriteLine(k);
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine(e.Message); 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("code to end");
            }

        }
    }
}
