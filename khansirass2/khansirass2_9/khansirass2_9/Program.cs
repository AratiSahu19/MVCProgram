using System;

namespace khansirass2_9
{
    class complex
    {
        public void Addition(double com1,double com2)
        {
            double add = com1 + com2;
            Console.WriteLine("addition of two complex no:" + add);
        }

        public void Subtraction(double com1, double com2)
        {
            double sub = com1 - com2;
            Console.WriteLine("subtraction of two complex no:" + sub);
        }

        public void Product(double com1, double com2)
        {
            double pro = com1 * com2;
            Console.WriteLine("product of two complex no:" + pro);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the real no");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the imaginary no");
            int im = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of i=");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the 2nd real no");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd imaginary no");
            int im1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value of i=");
            double i1 = Convert.ToDouble(Console.ReadLine());
            double complex1 = r + (im * i);
            double complex2 = r1 + (im1 * i1);
            complex c = new complex();
            c.Addition(complex1, complex2);
            c.Subtraction(complex1, complex2);
            c.Product(complex1, complex2);
            Console.ReadKey();




        }
    }
}
