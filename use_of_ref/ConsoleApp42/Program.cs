using System;

namespace ConsoleApp42
{
    class Program
    {
         static void show( ref int a, ref  int b )
        {
            
            int x = a;
            int y = b; 
            Console.WriteLine("value of a ="+x );
            Console.WriteLine("value of b=" + y);

        }
        static void Main(string[] args)
        {
            int a = 6,b=9;

            show( ref a,ref b );
            Console.ReadKey();
        }
    }
}
