using System;

namespace khansirass4_1
{
    abstract class Parent
    {
        public abstract void message();

    }
    class child1 : Parent
    {
        public override void message()
        {
            Console.WriteLine("This is the first subclass");

        }
    }
    class child2:Parent
    {
        public override void message()
        {
            Console.WriteLine("This is the second subclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new child1();
            p.message();
            Parent p1 = new child2();
            p1.message();
            Console.ReadKey();
        }
    }
}
