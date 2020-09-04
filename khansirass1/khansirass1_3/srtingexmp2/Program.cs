using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srtingexmp2
{
     public class Program
    {
        public string show(string name)
        {
           
            Console.WriteLine("welcome friend " +name);
            Console.WriteLine("have a nice day");
            return name ;
        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Program p = new Program();
            string s = p.show(name);
            Console.ReadKey();
        }

    }
}
