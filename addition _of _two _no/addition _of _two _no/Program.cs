using System;

namespace addition__of__two__no
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition of two no
            Console.WriteLine("enter the first no");
            byte num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter the second no");
            byte num2 = byte.Parse(Console.ReadLine());
            byte add = (byte)(num1 + num2);
            Console.WriteLine("Addition of two no is: {0}", add);

            //check greater no by bool datatype
            bool num3 = num1 > num2;
            Console.WriteLine(num3);




        }
    }
}
