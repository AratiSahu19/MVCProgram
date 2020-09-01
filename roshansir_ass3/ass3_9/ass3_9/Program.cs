using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n;
            Console.WriteLine("enter the no");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the no of line");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i< n;i++)
            {
                for(int j=1;j<2;j++)
                {
                    Console.Write(num * num +"  "+ num * num * num);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
