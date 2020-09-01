using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int days, year, month, left_day;
            Console.WriteLine("enter days");
            days = Convert.ToInt32(Console.ReadLine());
            year = days / 365;
            month = days / 30;
            left_day = days % 365;
            Console.WriteLine("year=" + year);
            Console.WriteLine("month=" + month);
            Console.WriteLine("left_day=" + left_day);
            Console.ReadKey();
        }

    }
}
