using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
     public class Program
    {
        public static int add(int n1, int n2)
        {
            return n1+n2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter two no");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int res = add(n1, n2);
            Console.WriteLine("addition of two no=" + res);            Console.ReadKey();
        }
    }
}
