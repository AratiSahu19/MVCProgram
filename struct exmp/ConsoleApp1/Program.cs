using System;

namespace ConsoleApp1
{
    public struct employee
    {
        public string frname;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee comemp;

            Console.WriteLine("enter name & age ");
            comemp.frname = Console.ReadLine();
            comemp.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name= " + comemp.frname);
            Console.WriteLine("age= " + comemp.age);
            Console.ReadKey();
        }

    }
}