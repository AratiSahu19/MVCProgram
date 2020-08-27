using System;

namespace practicle_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            float salary, hours, per_month;
            Console.WriteLine("enter id of employee");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter per hour salary of employee");
            salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter working hours");
            hours = Convert.ToSingle(Console.ReadLine());
            per_month = hours * salary;
            Console.WriteLine("Employee Id=" + id);
            Console.WriteLine("salary=" + per_month);
           
            Console.ReadKey();
        }
    }
}
