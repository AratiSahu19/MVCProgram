using System;

namespace ConsoleApp45
{
    class Program
    {
        static long add(params long[] v)
        {
            long  t, i;
            for (i=0,t=0;i<v.Length;i++)
            t += v[i];
            Console.WriteLine(" number is" + t);

            return t;

        }
        static void Main(string[] args)
        {
            long x = add(45, 74, 23);

            Console.ReadKey();
        }
    }
}
