using System;

namespace default_constructor
{
    class BankAccount
    {
        public int actno { get; set; }
        public BankAccount()
        {
            actno = 22;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            int no = ba.actno;
            Console.WriteLine("Account no=" + no);
            Console.ReadKey();
        }
    }
}
