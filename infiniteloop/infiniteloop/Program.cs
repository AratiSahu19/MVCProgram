using System;

namespace infiniteloop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )//infinite loop occur if the condition never becomes false
                      //When the conditional expression is absent, it is assumed to be true
            {
                Console.WriteLine("Hey! I am Trapped");
            }
        }
    }
}
