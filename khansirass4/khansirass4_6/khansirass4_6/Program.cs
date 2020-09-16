using System;

namespace khansirass4_6
{
    abstract class Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public double side { get; set; }
        public double radius { get; set; }
        public abstract void RectangleArea(double len,double bre);
        public abstract void SquareArea(double side1);
        public abstract void CircleArea(double rad1);

    }
    class Area:Shape
    {
        public override void RectangleArea(double len,double bre)
        {
            length = len;
            breadth = bre;
            double rec_area = length * breadth;
            Console.WriteLine("Area of rectangle=" + rec_area);

        }
        public override void SquareArea(double side1)
        {
            side = side1;
            double sqr_area = side * side;
            Console.WriteLine("Area of Square=" + sqr_area);

        }
        public override void CircleArea(double rad1)
        {
            radius = rad1;
            double circle_area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle=" + circle_area);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Area();
            s.RectangleArea(5, 8);
            s.SquareArea(5);
            s.CircleArea(6);
            Console.ReadKey();
        }
    }
}
