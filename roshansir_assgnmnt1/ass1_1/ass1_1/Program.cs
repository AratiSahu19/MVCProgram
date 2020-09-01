using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter weight and quantity of first item");
            float w1 = Convert.ToSingle(Console.ReadLine());
            float n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter weight and quantity of second item");
            float w2 = Convert.ToSingle(Console.ReadLine());
            float n2 = Convert.ToSingle(Console.ReadLine());
            float res = ((w1 * n1) + (w2 * n2)) / (n1 + n2);
            Console.WriteLine("average of item=" + res);
            Console.ReadKey();
        }
    }
}
