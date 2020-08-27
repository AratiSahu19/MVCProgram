using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while(i<=10)
            {
                Console.WriteLine(i);
                i++;
                if(i==5)
                    {
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
