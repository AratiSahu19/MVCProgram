using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] num = new int[] { 2, 4, 6 };
           
           
            foreach (int x in num)
            { 
                Console.WriteLine(x);
            }
          
            Console.ReadKey();

        }
    }
}
