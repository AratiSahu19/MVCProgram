using System;

namespace khansirass4_5
{
    abstract class Animals
    {
        public abstract void cats();
        public abstract void dogs();


    }
    class Cats:Animals
    {
        public override void cats()
        {
            Console.WriteLine("cat meows");
        }
        public override void dogs()
        {
            
        }
    }
    class Dogs:Animals
    {
        public override void cats()
        {
            
        }
        public override void dogs()
        {
            Console.WriteLine("dog Barks");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals a = new Cats();
            a.cats();
            Animals a1 = new Dogs();
            a1.dogs();
            Console.ReadKey();
        }
    }
}
