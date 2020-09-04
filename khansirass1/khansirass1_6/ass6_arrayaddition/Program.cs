using System;

namespace ass6_arrayaddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");
            for (int i=0; i<5; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            for(int i=0;i<arr.Length;i++)
            {
                total = total + arr[i];
            }
        
            Console.WriteLine("addition of array is" + total);
            Console.ReadKey();
        }

        
    }
}
