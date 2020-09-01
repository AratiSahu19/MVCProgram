using System;

namespace helloprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter character");
           int ch= Console.Read();
            Console.WriteLine("ascii is=" + ch);
            Console.WriteLine("ch=" + Convert.ToChar(ch));
          //Console.WriteLine("hello " + ch);

            Console.ReadKey();
        }
    }
}
