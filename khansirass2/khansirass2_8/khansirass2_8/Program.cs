using System;

namespace khansirass2_8
{
    class Average
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        double res = 0;
        public void Calculate(int n1,int n2,int n3)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
            res = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average of 3 nos=" + res);

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("enterthe 3 nos");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            Average a = new Average();
            a.Calculate(n1, n2, n3);
            Console.ReadKey();
        }
    }
}
