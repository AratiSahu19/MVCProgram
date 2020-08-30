using System;

namespace opps
{
    public class Student
    {
        public  string StudentName;
        public int StudentRollNo;


        public void Stud1(string name, int rollno)
        {
            StudentName = name;
            StudentRollNo = rollno;
            Console.WriteLine("name" + StudentName + "rollno" + StudentRollNo);
        }
    }
    class Program
    {
        public static int RollNo { get; private set; }

        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("enter name john");
            string name=Console.ReadLine();
            Console.WriteLine("enter rollno");
            int RollNo = Convert.ToInt32(Console.ReadLine());
            s.Stud1(name, RollNo);
            Console.ReadKey();
        }
    }
}
