using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec,hour,min,left_sec;
            Console.WriteLine("enter the sec");
            sec = Convert.ToInt32(Console.ReadLine());
            hour = sec / 3600;
            min = (sec-(3600* hour) )/ 60;
            left_sec = (sec - (3600 * hour) - (60 * min));
            Console.WriteLine("hour="+hour);
            Console.WriteLine("min=" +min);
            Console.WriteLine("left_sec=" + left_sec);
            Console.ReadKey();        
        }
    }
}
