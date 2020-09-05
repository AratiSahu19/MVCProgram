using System;

namespace khansirass2_3
{
    class Triangle
    {
        public double per;
        public Triangle(int len,int bre,int hei)
        {
            per = len + bre + hei;
            Console.WriteLine("perimeter is=" + per);
        }
        public void area_of_triangle(int len,int bre,int hei)
        {
            double area;
            area = (per - len) * (per - bre) * (per - hei);
            double res = per * area;
            double res1 = Math.Sqrt(res);
            Console.WriteLine("Area of triangle=" + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(3, 4, 5);
            tri.area_of_triangle(3, 4, 5);
            Console.ReadKey();
        }
    }
}
