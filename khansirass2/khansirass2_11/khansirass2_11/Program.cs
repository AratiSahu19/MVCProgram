using System;

namespace khansirass2_11
{
    class AddDistance
    {
        public void show(double res,double res1)
        {
            if(res1>12)
            {
                res++;
                res1 = res1 - 12;
                Console.WriteLine("Total distance in feet" +res+ "inch" + res1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first feet");
            double feet1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the first inch");
            double inch1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd feet");
            double feet2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd inch");
            double inch2 = Convert.ToDouble(Console.ReadLine());
            double res1 = feet1 + feet2;
            double res2 = inch1 + inch2;
            AddDistance ad = new AddDistance();
            ad.show(res1, res2);
            Console.ReadKey();

        }
    }
}
