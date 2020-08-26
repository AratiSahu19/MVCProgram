using System;
using System.Collections;

namespace hashtablecoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "arti");
            ht.Add(2, "puja");
            ht.Add(3, "jyoti");
            ht.Add(4, "ashwin");
            ht.Add(5, "Anant");
            if(ht.ContainsValue("arti"))
            {
                Console.WriteLine("already exist");

            }
            else
            {
                ht.Add(6, "arti");
            }
            ICollection key = ht.Keys;
            foreach(int k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            Console.ReadKey();
          
        }
    }
}
