using System;

namespace khansirass1_2
{
    class Program
    {
        public string prime(int num)
        {
            int i = 1, k = 1;
            string str;
            while(num>i)
            {
                if(num%i==0)
                {
                    k = k + 1;
                    i++;

                }
            }
            if(k==2)
            {
                str = "prime";

            }
            else
            {
                str = "not prime";
            }
            return str;
        }
        static void Main(string[] args)
        {
            int n;
            string s;
            Console.WriteLine("enter a no");
            n = int.Parse(Console.ReadLine());
            Program p = new Program();
            s = p.prime(n);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
