using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dis;
            float fuel_con;
            Console.WriteLine("enter distance and fuel consumed");
            dis = Convert.ToInt32(Console.ReadLine());
            fuel_con = Convert.ToSingle(Console.ReadLine());
            float avg_con = dis / fuel_con;
            Console.WriteLine("average consumption=" +avg_con);
            Console.ReadKey();
        }
    }
}
