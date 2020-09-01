using System;

namespace exceptioninarray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i;
                int[] arr = new int[4];
                Console.WriteLine("enter element");
                for (i = 0; i <= 5; i++)
                {
                    arr[i]=int.Parse(Console.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
    }
    
