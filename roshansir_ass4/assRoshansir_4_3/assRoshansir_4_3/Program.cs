using System;

namespace assRoshansir_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rev,n1,n2,n3 ;
            Console.WriteLine("Enter three digit number");
            num = Convert.ToInt32(Console.ReadLine());
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            num = num / 10;
            n3 = num % 10;
            rev = n1 * 100 + n2 * 10 + n3 * 1;
            Console.WriteLine("Reverse Number is" + rev);
            Console.ReadKey();
        }
    }
}
