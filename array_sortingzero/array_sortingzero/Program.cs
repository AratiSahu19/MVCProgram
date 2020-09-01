using System;

namespace array_sortingzero
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i, size;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements in array" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("Sorting array list" + arr[i]);
            }
            Console.WriteLine("Nearest elements of zero" + arr[0] +"and"+ arr[1]);
            int sum = 0;
            for(i=0;i<2;i++)
            {
                sum = sum +arr[i];
            }
            Console.WriteLine("addition of two nearest element of zero is:" + sum);
            Console.ReadKey();
        }
    }
}
