using System;

namespace khansirass2_7
{
    class Average
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }
public double res=0;
        public void Calculate(int num1,int num2,int num3)
        {
            number1 = num1;
            number2 = num2;
            number3 = num3;
            res = number1 + number2 + number3;
        }
        public string average()
        {
            return "res";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 nos:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Average av = new Average();
            av.Calculate(num1, num2, num3);
            string res = av.average();
            Console.WriteLine("Average of 3 nos=" + res);
            Console.ReadKey();
        }
    }
}
