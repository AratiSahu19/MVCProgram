using System;

namespace khansirass2_2
{
    class student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public void getDetail(int rollno,string name)
        {
            RollNo = rollno;
            Name = name;

        }
        public void showData()
        {
            Console.WriteLine("Roll No=" + RollNo);
            Console.WriteLine("Name=" + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int Rollno = 0;
            string Name = "";
            Console.WriteLine("enter the size");
            int n = Convert.ToInt32(Console.ReadLine());
            student[] stud = new student[n];
            for(i=0;i<n;i++)
            {
                stud[i] = new student();
                Console.WriteLine("enter the rollno");
                Rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the name ");
                Name = Convert.ToString(Console.ReadLine());
                stud[i].getDetail(Rollno, Name);

            }
            for(i=0;i<n;i++)
            {
                stud[i].showData();
            }
            Console.ReadKey();
        }
    }
}
