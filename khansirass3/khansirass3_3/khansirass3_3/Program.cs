using System;

namespace khansirass3_3
{
    class student
    {
        public int height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("enter the no of students");
            n = Convert.ToInt32(Console.ReadLine());
            student[] s = new student[n];
            for (int i=0;i<n;i++)
            {
                s[i] = new student();
                Console.WriteLine("enter the height of student");
                s[i].height = Convert.ToInt32(Console.ReadLine());
                sum = s[i].height + sum;
            }
            double avg = sum / n;
            Console.WriteLine("Average height of all students=" + avg);
            Console.ReadKey();
        }
    }
}
