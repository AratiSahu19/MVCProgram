using System;

namespace Abstraction_method
{
   abstract class Animal
    {
        public abstract void Birds();

        public void PetAnimlas(string petanimals)
        {
            Console.WriteLine("hello" + petanimals);
        }
        
    }
    class Bird : Animal
    {
        public override void Birds()
        {
            Console.WriteLine("I want to fly");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string petanml;
            Console.WriteLine("Enter Any Bird name here");
            petanml = Console.ReadLine();
            Animal an = new Bird();
            an.PetAnimlas(petanml);
            an.Birds();
            Console.ReadKey();
        }
    }
}
