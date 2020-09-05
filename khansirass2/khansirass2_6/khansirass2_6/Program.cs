using System;

namespace khansirass2_6
{
    class Area
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public void setDim(int len,int bre)
        {
            length = len;
            breadth = bre;

        }
        public double getArea()
        {
            return length * breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int length1, breadth1;
            Console.WriteLine("Enter the length");
            length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth1 = Convert.ToInt32(Console.ReadLine());

            Area ar = new Area();
            ar.setDim(length1, breadth1);
            Console.WriteLine("Area=" + ar.getArea());
            Console.ReadKey();
        }
    }
}
