


using System;

namespace Class_classprogrm
{
    class Student
    {
       public class Teacher
        {
            int id;
            string name;
            double ph_no;
            public void show(int Id, string Name, double Phono)
            {
                id = Id;
                name = Name;
                ph_no = Phono;
                Console.WriteLine("Your id {0} Name {1} and Phonenumber {2}", id, name, ph_no);
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            double phno;
            Console.WriteLine("Enter id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your full name");
            name = Console.ReadLine();
            Console.WriteLine("Enter 10 digit number");
            phno = Convert.ToDouble(Console.ReadLine());

            Student.Teacher s = new Student.Teacher();
            s.show(id, name, phno);
            Console.ReadKey();
            
        }
    }
}
