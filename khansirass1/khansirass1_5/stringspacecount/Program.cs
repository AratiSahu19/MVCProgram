using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringspacecount
{
     public class Program
    {
        public  int sentence1(string sentence)
        {
            int count=0;
            for(int i=0;i<sentence.Length;i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("enter a sentence");
            sentence = Console.ReadLine();
            Program p = new Program();
            int res = p.sentence1(sentence);
            Console.WriteLine("no of space=" + res);
            Console.ReadKey();
        }
    }
}
