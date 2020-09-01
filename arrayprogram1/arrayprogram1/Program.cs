using System;

namespace arrayprogram1
{
    class Program
    {
        static  void Main(string[] args)
        {
            int[] arr = new int[50];
            int size1;
            
            Console.WriteLine("Enter the size of array");
            size1 = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i<size1;i++)
            {
                Console.WriteLine("Enter element" + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
               // Console.WriteLine("");
            }
            Console.WriteLine("");
            Program p = new Program();
         int[] res= p.parameter(arr,size1);
            Console.WriteLine("");
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine("updated list" + res[i]);
              
            }


            Console.ReadKey();
            
        }

        public int[] parameter(int[] arg,int size1)
            {
            int i;
        for( i=0;i<size1;i++)
            {
                Console.WriteLine("elements of array is:" + arg[i]);
                arg[i]++;
            }
            return arg;
        }
    }
}
