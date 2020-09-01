using System;

namespace addref
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,res;
            Console.WriteLine("enter two no");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            res = refadd(ref n1, ref n2);
            Console.WriteLine("addition=" + res);
        }
        static int refadd(ref int num1,ref int num2 )
        {
            return num1 + num2;
        }
    }
}
