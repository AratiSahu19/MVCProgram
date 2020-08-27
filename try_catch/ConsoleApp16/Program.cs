using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number:");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("number is " + i);

            }
            catch(OverflowException e )
            {
                Console.WriteLine("no is out of range");
            }
            catch(Exception e)
            {
                Console.WriteLine("not a valid no ");
            }
            Console.WriteLine("code reached till the end ");
            Console.ReadKey();


        }
    }
}


