using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, count1 = 0;
            int[] num = new int[5];
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("enter the 5 nos");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i<5;i++)
            {
                if(num[i]>0)
                {
                    count++;
                }
                else
                {
                    count1++;
                }



            }
            Console.WriteLine("no of positive=" + count);
            Console.WriteLine("no of negative=" + count1);
            Console.ReadKey();
        }
    }
}
