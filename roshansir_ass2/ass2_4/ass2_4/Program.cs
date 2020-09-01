using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp=0;
            Console.WriteLine("enter two no");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1<num2)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;


            }
            if(num1%num2==0)
            {
                Console.WriteLine("no is multiplied");

            }
            else
            {
                Console.WriteLine("not multiplied");
            }
            Console.ReadKey();
        }
    }
}
