using System;

namespace array_insertele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int i,size, pos ;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements in array" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("List before insert element");
            for( i=0;i<size;i++)
            {
                Console.WriteLine("List is" + arr[i]);
            }
            Console.WriteLine("Where you want to insert element: insert position");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element which you want to enter");
            int num = Convert.ToInt32(Console.ReadLine());
            for( i=size;i>=pos;i--)
            {
                arr[i] = arr[i - 1];
                
            }
            arr[pos-1] = num;
            for (i = 0; i <= size; i++)
            {
                Console.WriteLine("Array list after inserting the array element" + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
