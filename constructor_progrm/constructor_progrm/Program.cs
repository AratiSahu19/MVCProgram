using System;

namespace constructor_progrm
{
    class School
    {
        public int id;
        public string name;
        public School(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Constructor is called"+id+name);
        }
        public School( School temp)
        {
            id = temp.id;
            name = temp.name;
            Console.WriteLine("Copy constructor is called" + id + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your id");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter You Name");
            string name1 = Console.ReadLine();
            School s = new School(id1, name1);
            School s1 = new School(s);
            Console.ReadKey();
        }
    }
}
