using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;
            Console.WriteLine("enter the password");
            password = Convert.ToInt32(Console.ReadLine());
            switch(password)
            {
                case 1234:
                    Console.WriteLine("correct password");
                    break;
                default:
                    Console.WriteLine("invalid password");
                    break;

            }
            Console.ReadKey();
        }
    }
}
