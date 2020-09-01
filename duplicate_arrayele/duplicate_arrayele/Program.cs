using System;

namespace duplicate_arrayele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int size,count=0;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<size;i++)
            {
                Console.WriteLine("Enter the elements in array" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<size;i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if(arr[i]==arr[j])
                    {
                         count = count + 1;
                    }
                }
                    
            }
            Console.WriteLine("duplicate elements are" + count);
            Console.ReadKey();
        }
    }
}
