using System;

namespace khansir_ass1_1
{
    public class showstring
    {
        public string message()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("have a nice day");
            return "";
        }

        class Program
        {
            static void Main(string[] args)
            {
                showstring ss = new showstring();
                ss.message();
                Console.ReadKey();
            }
        }
    }
}
