using System;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 123;
            //object obj = num;
            //Console.WriteLine(num);
            //Console.WriteLine(obj);
            object obj = 123;
            int num = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(num);
    }
    }
}
