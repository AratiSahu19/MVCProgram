using System;

namespace single_inheritance
{
    class person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        
    }

    class Employee:person
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeDesignation { get; set; }
        public double EmployeeSalary { get; set; }
       
        
        

        
        public void showEmployeeDetails()
        {
            Console.WriteLine("employee datails are:");
            Console.WriteLine("empno:" + EmployeeNumber);
            Console.WriteLine("empdesignation:" + EmployeeDesignation);
            Console.WriteLine("employeesalary:" + EmployeeSalary);
            
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee();
            Console.WriteLine("enter employee number");
            employee1.EmployeeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            employee1.Name = Console.ReadLine();
            
            Console.WriteLine("enter employee address");
             employee1.Address = Console.ReadLine();
            Console.WriteLine("enter employee designation");
            employee1.EmployeeDesignation = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            employee1.EmployeeSalary = Convert.ToDouble(Console.ReadLine());
            
            employee1.showEmployeeDetails();
            Console.ReadKey();
        }
    }
}
