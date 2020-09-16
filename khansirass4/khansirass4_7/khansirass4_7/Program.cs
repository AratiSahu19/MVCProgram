using System;

namespace khansirass4_7
{
    abstract class Shape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public double side { get; set; }
        public double radius { get; set; }
        public abstract void RectangleArea(double len, double bre);
        public abstract void SquareArea(double side1);
        public abstract void CircleArea(double rad1);

    }
    class Area : Shape
    {
        public override void RectangleArea(double len, double bre)
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
            Console.WriteLine("Area of square=" + sqr_area);
        }
        public override void CircleArea(double rad1)
        {
            radius = rad1;
            double cir_area = radius * radius;
            Console.WriteLine("Area of circle=" + cir_area);

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            double length = 0, breadth = 0, side = 0, radius = 0;
            string ch;
            Console.WriteLine("enter the choice rectangle,square or circle to find the area");
            ch = Console.ReadLine();
            switch(ch)
            {
                case "rectangle":
                    {
                        Shape[] s = new Area[4];
                        for(int i=0;i<4;i++)
                        {
                            s[i] = new Area();
                            Console.WriteLine("enter the length and breadth");
                            length = Convert.ToDouble(Console.ReadLine());
                            breadth = Convert.ToDouble(Console.ReadLine());
                            s[i].RectangleArea(length, breadth);

;
                        }
                        break;

                    }
                case "square":
                    {
                        Shape[] s = new Shape[4];
                        for(int i=0;i<4;i++)
                        {
                            s[i] = new Area();
                            Console.WriteLine("enter the side of square");
                            side = Convert.ToDouble(Console.ReadLine());
                            s[i].SquareArea(side);
                        }
                        break;
                    }
                case "circle":
                    {
                        Shape[] s = new Shape[4];
                        for(int i=0;i<4;i++)
                        {
                            s[i] = new Area();
                            Console.WriteLine("enter the radius of the circle");
                            radius = Convert.ToDouble(Console.ReadLine());
                            s[i].CircleArea(radius);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("not avalid choice! Please enter a valid choice");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
