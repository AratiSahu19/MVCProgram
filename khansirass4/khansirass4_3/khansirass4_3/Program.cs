using System;

namespace khansirass4_3
{
    abstract class Marks
    {
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public  int marks3 { get; set; }
        public abstract void getPercent();
       
    }
    class A:Marks
    {
        public A(int m1,int m2,int m3)
        {
            marks1 = m1;
            marks2 = m2;
            marks3 = m3;

        }
        public override void getPercent()
        {
            double per = (marks1 + marks2 + marks3) / 3;
            Console.WriteLine("percentage of A: {0}", per);
        }
    }
    class B:Marks
    {
        public B(int ma1,int ma2,int ma3)
        {
            marks1 = ma1;
            marks2 = ma2;
            marks3 = ma3;
        }
        public override void getPercent()
        {
            double per1 = (marks1 + marks2 + marks3) / 3;
            Console.WriteLine("Percentage of B: {0}", per1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marks m = new A(40, 50, 60);
            m.getPercent();
            Marks m1 = new B(70, 40, 50);
            m1.getPercent();
            Console.ReadKey();
        }
    }
}
