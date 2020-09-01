using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addittion_2array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            int[]b = new int[4];
            //int result=0,sum=0;
            int[] result = new int[4];
            int i ;
            Console.WriteLine("enter first array element: ");
            for(i=0;i<=3;i++)
            {
              
                    a[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("enter second array element: ");
            for(i=0;i<=3;i++)
            {
              
                    b[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine("final array addittion is: ");
            for (i = 0; i <= 3; i++)
            {

                result[i] = a[i]+b[i];
                Console.WriteLine(result[i]);


            }
            Console.ReadKey();
            
        }
    }
}
