using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] num = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i<5;i++)
            {
                if(num[i]%2==1)
                {
                    sum = sum + num[i];
                }
            }
            Console.WriteLine("sum=" + sum);
            Console.ReadKey();
        }
    }
}
