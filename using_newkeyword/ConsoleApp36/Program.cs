using System;

namespace ConsoleApp36
{
    class Program
    {
        public void method()
        {
            Console.WriteLine("By creating instance of a class");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.method();
            Console.ReadKey();
        }
    }
}
