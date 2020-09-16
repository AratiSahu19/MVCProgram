using System;

namespace khansirass4_2
{
    abstract class Bank
    {
        public abstract void getBalance( int amt);
    }
    class BankA:Bank
    {
        public override void getBalance(int amt)
        {
            Console.WriteLine("Deposit: {0}" ,amt);
        }
    }
    class BankB:Bank
    {
        public override void getBalance(int amt)
        {
            Console.WriteLine("Deposit=" + amt);
        }
    }
    class BankC : Bank
    {
        public override void getBalance(int amt)
        {
            Console.WriteLine("Deposit=" + amt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new BankA();
            b1.getBalance(100);
            Bank b2 = new BankB();
            b2.getBalance(200);
            Bank b3 = new BankC();
            b3.getBalance(300);
            Console.ReadKey();
        }
    }
}
