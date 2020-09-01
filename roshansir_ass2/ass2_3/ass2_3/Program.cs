using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, per;
            Console.WriteLine("enter value of a");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter value of b");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter value of c");
            c = Convert.ToSingle(Console.ReadLine());

            if(a<(b+c) && b<(a+c) && c<(b+a))
            {
                per = a + b + c;
                Console.WriteLine("perimeter=" + per);
            }
            else
            {
                Console.WriteLine("not possible");
            }
            Console.ReadKey();


        }
    }
}
