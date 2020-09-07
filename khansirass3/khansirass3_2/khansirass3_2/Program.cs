using System;

namespace khansirass3_2
{
    class student
    {
        int i;
        public int m1 { get; set; }
        public int m2 { get; set; }
        public int m3 { get; set; }
        public void getdetails(int marks1,int marks2,int marks3,int i1)
        {
            m1 = marks1;
            m2 = marks2;
            m3 = marks3;
            i = i1 + 1;
            double avg = (m1 + m2 + m3) / 3;
            Console.WriteLine("roll no=" + i);
            Console.WriteLine("Average of 3 subjects marks=" + avg);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            student[] s = new student[3];
            for(i=0;i<3;i++)
            {
                s[i] = new student();
                Console.WriteLine("enter the marks of subject1");
                s[i].m1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the marks of subject2");
                s[i].m2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the marks of subject3");
                s[i].m3 = Convert.ToInt32(Console.ReadLine());

                s[i].getdetails(s[i].m1, s[i].m2, s[i].m3,i);

            }
        }
    }
}
