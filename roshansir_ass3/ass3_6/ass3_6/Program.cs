using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum=0;
            Console.WriteLine("enter the first no");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second no");
            num2 = Convert.ToInt32(Console.ReadLine());

            for(int i= num1; i<= num2; i++)
            {
                if(i%7==2 || i%7==3)
                    {
                    sum = sum + i;
                }

            }
            Console.WriteLine("sum of no=" + sum);
            Console.ReadKey();
        }
    }
}
