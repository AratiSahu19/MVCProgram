using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("even nos are");
            for(i=1;i<50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
