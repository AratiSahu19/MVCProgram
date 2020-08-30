using System;

namespace delegats
{
    class Account
    {
        public int balance = 1000;
        public string deposit(int amt)
        {
            balance = balance + amt;
            return "balance after amount deposited is: " + balance;
        }
        public string withdrawl(int amt)
        {
            balance = balance - amt;
            return "balance after amount withdrawl is: " + balance;
        }
    }
    class Program
    {
        public delegate string accountdelegate(int amt);
        static void Main(string[] args)
        {
            Console.WriteLine("enter amount please");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter deposit or withdrawl");
            string t = Console.ReadLine();
            Account act = new Account();
            accountdelegate ad = null;
            switch(t)
            {
                case "deposit":
                    ad = new accountdelegate(act.deposit);
                    break;
                case "withdrawl":
                    ad = new accountdelegate(act.withdrawl);
                    break;
                default:
                    Console.WriteLine("you should enter deposit or withdrawl dear");
                    break;
            }
            if(ad!=null)
            {
                string result = ad(amount);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
