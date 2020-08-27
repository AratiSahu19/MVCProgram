using System;

namespace shiftbybits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter data");
            int num = Convert.ToInt32(Console.ReadLine());
           num <<= 2;
            int num2 = num;
            Console.WriteLine("number is" + num2);
            Console.ReadKey();
        }
    }
}
