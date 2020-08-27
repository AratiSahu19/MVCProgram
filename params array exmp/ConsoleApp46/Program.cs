using System;

namespace ConsoleApp46
{
    class Program
    {
         static int add(params int[] val)
        {
            int sum = 0, i;
            for( i=1;i<val.Length;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(" sum is " + sum);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");


            int[] a = new int[5];
            add(a);
           
        }
    }
}
