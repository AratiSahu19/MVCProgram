using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum=0;
            Console.WriteLine("enter first no");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second no");
            num2 = Convert.ToInt32(Console.ReadLine());
            for(int i= num1;i<= num2;i++)
            {
                if(i%17!=0)
                {
                    Console.WriteLine("no which are not divisible by 17 is ", +i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of no=" + sum);
            Console.ReadKey();
        }
    }
}
