using System;  

namespace ConsoleApp50
{
    class simpleclass
    {
        public static readonly long baseline;

        static simpleclass()
        {
            baseline = DateTime.Now.Ticks;
            Console.WriteLine("data: " + baseline);
        }
        public simpleclass()
        {
            Console.WriteLine("hello from public constructor");
        }
            




    }
    class Program
    {
        static void Main(string[] args)
        {
            simpleclass s = new simpleclass();
            
            Console.ReadKey();
           
        }
    }
}
