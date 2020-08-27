using System;

namespace ConsoleApp9
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int x = 5, i;
            Console.WriteLine("enter the value of n:");
            int X = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= X; i++)
                Console.WriteLine("element is " + X);
            Console.ReadKey();


            
        }
    }
}
