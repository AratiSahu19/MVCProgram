using System;

namespace array_replaceelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int i, size, replace,num;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements in array" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("List before replace element");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine("List is" + arr[i]);
            }
            Console.WriteLine("Which element you want to replace ");
            replace = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And with");
             num = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < size; i++)
            {
                if (arr[i] == replace)
                {
                    arr[i] = num;
                }
            }
            Console.WriteLine("After replacement of the value");
            
            for(i=0;i<size;i++)
            {
                Console.WriteLine("Updated list" + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
