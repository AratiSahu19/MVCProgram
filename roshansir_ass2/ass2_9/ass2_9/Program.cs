using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0,sum=0;
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the 5 nos");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                if (num[i] > 0)
                {
                    sum = sum + num[i];
                    count++;
                }

            }
            float avg = sum / count;
            Console.WriteLine("average of positive no=" + avg);
            Console.ReadKey();


        
        }
    }
}
