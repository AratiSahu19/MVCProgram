using System;

namespace khansirass2_5
{
    class Rectangle
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public Rectangle(int len,int bre)
        {
            length = len;
            breadth = bre;
        }
        public double Area()
        {
            return length * breadth;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4,5);
            double result = rect.Area();
            Console.WriteLine("area of rectangle1=" + result);
            Rectangle rect1 = new Rectangle(5, 6);
            double result2 = rect1.Area();
            Console.WriteLine("area of rectangle2=" + result2);
            Console.ReadKey();

        }
    }
}
