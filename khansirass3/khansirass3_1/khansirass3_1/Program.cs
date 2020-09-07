using System;

namespace khansirass3_1
{
    class Employee
    {
        public string Name { get; set; }
        public string Date_of_joining { get; set; }
        public double Salary { get; set; }
        public void show()
        {
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Salary=" + Salary);
            Console.WriteLine("Date of joining=" + Date_of_joining);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];
            for(int i=0;i<10;i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter the name");
                emp[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the date of joining");
                emp[i].Date_of_joining = Console.ReadLine();
                Console.WriteLine("Enter the salary");
                emp[i].Salary = Convert.ToDouble(Console.ReadLine());
                emp[i].show();
                Console.ReadKey();
            }
        }
    }
}
