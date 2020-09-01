using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("enter no of student marks ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] marks = new int[n];
            for(int i=0;i< n;i++)
            {
               

                Console.WriteLine("enter the marks of student");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                if (marks[i] < 0)
                {
                    Console.WriteLine("please enter a positive no");
                    continue;
                }
                    
                sum = sum + marks[i];
            }
            float avg = sum / n;
            Console.WriteLine("average of n no of student" + avg);
            Console.ReadKey();
        }
    }
}
