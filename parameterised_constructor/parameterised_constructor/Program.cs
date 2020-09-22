using System;

namespace parameterised_constructor
{
    public class Person
    {
        private string first;
        private string last;

        public Person(string firstname,string lastname)
        {
            first = firstname;
            last = lastname;
        }
        public void show()
        {
            Console.WriteLine("FirstName=" + first);
            Console.WriteLine("LastName=" + last);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("amit", "saha");
            p.show();
            Console.ReadKey();
        }
    }
}
