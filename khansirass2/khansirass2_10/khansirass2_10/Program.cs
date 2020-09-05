using System;

namespace khansirass2_10
{
    class Employee
    {
        public string Name { get; set; }
        public string year_of_joining { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
         public void show()
        {
            Console.WriteLine("{0}      {1}       {2}       {3}", Name, year_of_joining, Address, Salary);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[4];
            for(int i=0;i<=3;i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter the name");
                emp[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the joining year");
                emp[i].year_of_joining = Console.ReadLine();

                Console.WriteLine("Enter the address");
                emp[i].Address = Console.ReadLine();

                Console.WriteLine("Enter the salary");
                emp[i].Salary =Convert.ToDouble( Console.ReadLine());   

            } 
            for(int i=0;i<=3;i++)
            {
                emp[i].show();
            }
            Console.ReadKey();
        }
    }
}
