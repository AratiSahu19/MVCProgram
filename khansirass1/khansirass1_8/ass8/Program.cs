using System;

namespace ass8
{
   public class Program
    {
        static void Main(string[] args)
        {
            int num, power;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter the power of number");
            power = Convert.ToInt32(Console.ReadLine());
            int res = Program.function1(num,power);
            Console.WriteLine("result" + res);
            Console.ReadKey();

        }
        public static int function1(int num,int power)
        {
            int res1=1;
           
            
            while (power !=0)
            {
                res1 = res1*num;
                power--;
            }
            return res1;
        }
    }
}
