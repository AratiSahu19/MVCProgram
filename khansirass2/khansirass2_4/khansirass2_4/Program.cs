using System;

namespace khansirass2_4
{
    class triangle
    {
        public double perimeter;
        public double area; 
        public triangle()
        {
            int a = 3;
            int b = 4;
            int c = 5;
        }
        public void per(int a, int b, int c)
        {
            perimeter = a + b + c;
            Console.WriteLine("perimeter=" + perimeter);
        }
        public void Area(int a,int b,int c)
        {
            area = (perimeter - a) * (perimeter - b) * (perimeter - c);
            double res = perimeter * area;
            double res1 = Math.Sqrt(res);
            Console.WriteLine("Area of triangle=" + res1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            triangle t = new triangle();
            t.per(3, 4, 5);
            t.Area(3, 4, 5);
            Console.ReadKey();

        }
    }
}
