using System;

namespace stringprintcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
           // Console.WriteLine("My name is : {0}", name);// by using placeholder to display the name with message
            Console.WriteLine("My name is :" + name);// by using concatenation
            Console.ReadKey();
        }
    }
}
