using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraydisplayfn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("enter size");
            n = Convert.ToInt32(Console.ReadLine());

           
           int[] arra= display(n);
            foreach(int i in arra)
            {
                Console.WriteLine("i=" + i);
            }
            Console.ReadKey();
        }
        static int[] display(int size)
        {
            int[] arr = new int[size];
            Console.WriteLine("enter element");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            return arr;
        }
    }
}
