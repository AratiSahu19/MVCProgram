using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the empid,");
            double empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter hour");
            float hr = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("enter  per hour salary");
            float per_hr_sal = Convert.ToSingle(Console.ReadLine());

            float mon_sal = hr * per_hr_sal;

            Console.WriteLine("Total salary=" + mon_sal);
            Console.ReadKey();

        }
    }
}
