using System;

namespace ass_Roshansir4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,rem=0;
            Console.WriteLine("Enter the number below 500");
            num = Convert.ToInt32(Console.ReadLine());

            while (num!=0)
            {
                rem = rem+ num % 10;
                num = num / 10;
                   
            }
            
            Console.WriteLine("Addition of given number is:"+rem);
            Console.ReadKey();

        }
    }
}
