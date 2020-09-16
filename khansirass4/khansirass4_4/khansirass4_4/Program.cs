using System;

namespace khansirass4_4
{
    abstract class Parent
    {
        public Parent()
        {
            Console.WriteLine("this is A constructor");

        }
        public abstract void a_method();
        public void show()
        {
            Console.WriteLine("this is the normal method of abstract class parent");
        }
    }
    class child:Parent
    {
        public override void a_method()
        {
            Console.WriteLine("this is a abstract method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new child();
            p.a_method();
            p.show();
            Console.ReadKey();
        }
    }
}
