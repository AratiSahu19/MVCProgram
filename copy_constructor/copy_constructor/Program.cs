using System;

namespace copy_constructor
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(int age,string name)
        {
            Age = age;
            Name = name;
        }
        public Person(Person pv)
        {
            Age = pv.Age;
            Name = pv.Name;
        }
        public string Details()
        {
            return Name + "  is  " + Age.ToString()+ " years  old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(18, "Jhon");
            Person p2 = new Person(p);
            Console.WriteLine("original:" + p.Details());
            Console.WriteLine("copy:" + p2.Details());
            Console.ReadKey();

        }
    }
}
