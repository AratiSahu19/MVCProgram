using System;

namespace ass9_fibonacci
{
  public  class Program
    {
        static void Main(string[] args)
        {
            int num=0 ,num1=0,num2=1;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Program.function1(num,num1,num2);
            Console.ReadKey();
        }
        public static int function1(int num,int num1,int num2)
        {
            int res = 0;

            while (res <= num)
            {
                res = num1 + num2;

                if (res <= num)
                {
                    num1 = num2;
                    num2 = res;
                    Console.WriteLine("series is" + res);
                }
               
            }
            return 0;

        }
    }
}
