using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysum
{
    public class Program
    {
        public  int arraysum(int[] arr)
        {
            int total = 0;
            for(int i=0;i<3;i++)
            {
                total = total + arr[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter element");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Program p = new Program();
            int res = p.arraysum(arr);
            Console.WriteLine("sum of array element=" + res);
            Console.ReadKey();

        }
    }
}
