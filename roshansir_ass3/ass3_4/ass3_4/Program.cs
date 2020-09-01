using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("enter two no");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1%num2==0)
            {
                Console.WriteLine("{0} is divisible by{1}",num1, num2);

            }
            else
            {
                Console.WriteLine("{0} is not divisible by{1}", num1, num2);
            }
            Console.ReadKey();
        }
    }
}
