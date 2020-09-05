using System;

namespace khansirass2_1
{
    class student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public void GetDetail(int rollno,string name)
        {
            Name = name;
            RollNo = rollno;
        }

        public void showData()
        {
            Console.WriteLine("Roll no=" + RollNo);
            Console.WriteLine("Name=" + Name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.GetDetail(2, "John");
            stud.showData();
            Console.ReadKey();
            
        }
    }
}
