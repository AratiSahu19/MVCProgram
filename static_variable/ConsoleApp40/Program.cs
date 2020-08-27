using System;

namespace ConsoleApp40
{
    class Program
    {
        static int num = 40;
        public static void exam()
        {
            int num = 20;
            Console.WriteLine(" number " + num);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("number is "+num);
            Program.exam();
            Console.WriteLine("number = " + num);
            Console.ReadKey();

        }
    }
}
