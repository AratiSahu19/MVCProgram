using System;

namespace ConsoleApp41
{
    class Program
    {
        static int add()
        {
            int a, b;
            a = b = 7;
            return a + b;

        }
        static void Main(string[] args)
        {
            int x;
            x = Program.add();

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
