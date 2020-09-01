using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        //1.program (simple array)

        /*  static void Main(string[] args)
          {
              int[] arr = new int[4];
              int i;
              Console.WriteLine("enter array element: ");
              for(i=0;i<=3;i++)
              {
                  arr[i] = int.Parse(Console.ReadLine());
              }
              Console.WriteLine("printed array elements are: ");
              for(i=0;i<=3;i++)
              {
                  Console.WriteLine(arr[i]);
              }
              Console.ReadKey();

          }*/




        //2.program (method without return type and without argument
        /*static void Main(string[] args)
        {
            array();
            Console.ReadKey();
        }
        static void array()
        {
            int[] arr = new int[4];
            int i;
            Console.WriteLine("enter array element: ");
            for (i = 0; i <= 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("printed array elements are: ");
            for (i = 0; i <= 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }*/






        //3.program without return type and with argument

        static void Main(string[] args)
        {
            int[] arr = new int[4];
            int i;
            Console.WriteLine("enter array element: ");
            for (i = 0; i <= 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            array(arr);
            Console.ReadKey();
        }
        static void array(int[] a)
        {
            int i;
            Console.WriteLine("printed array elements are: ");
            for (i = 0; i <= 3; i++)
            {
                Console.WriteLine(a[i]);
            }

        }






        //4.with return type and without argument

    }
}
