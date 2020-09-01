using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x=1;
            Console.WriteLine("enter no of lines");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<= n;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    Console.Write(x++);
                    
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
