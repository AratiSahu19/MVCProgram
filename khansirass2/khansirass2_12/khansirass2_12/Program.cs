using System;

namespace khansirass2_12
{
    class Employee
    {
        public double Salary { get; set; }
        public double Noofhours { get; set; }
        public void getInfo(double salary,double noofhrs)

            {

            Salary = salary;
            Noofhours = noofhrs;
        }
        public void Addsal()
        {
            if(Salary<500)
            {
                double Newsalary = Salary + 10;
                Console.WriteLine("Salary=" + Newsalary);
            }
        }
        public void AddWork()
        {
            if(Noofhours>6)
            {
                Salary = Salary + 5;
                Console.WriteLine("salary=" + Salary);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("enter Salary");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter no of hrs");
            double noofhours = Convert.ToDouble(Console.ReadLine());
            emp.getInfo(Salary, noofhours);
            emp.Addsal();
            emp.AddWork();
            Console.ReadKey();
        }
    }
}
