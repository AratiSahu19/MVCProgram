using System;

namespace runtime_polymorphism
{
    class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 1000;
        }
        public virtual string deposit(double amount)
        {
            return "hello from account class deposit method";
        }
        public string ShowBalance()
        {
            return "Balance+amount+Interest" + AccountNumber+"is"+Balance;
        }
    }
    class Loan:Account
    {
       

        public override string deposit(double amount)
        {
           int interest = 500;
            Balance = Balance + amount + interest;
            return "Amount deposit successfully with interest,balance is:" + Balance;
        }
    }
    class Saving:Account
    {
        private double interest;

        public override string deposit(double amount)
        {
            interest = 400;
            Balance = Balance + amount + interest;
            return "Amount deposit successfully with interest, balance is:" + Balance;

        }
    }
    class Current : Account
    {
        public override string deposit(double amount)
        {
            Balance = Balance + amount;
            return "Amount Deposit successfully without interest,balance is:" + Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int actno;
            double amt;
            Console.WriteLine("enter account number ");
            actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount ");
            amt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter amount type (saving or current or loan)");
            string acounttype = Console.ReadLine();
            string result = null;
            string result1 = null;
            
            Account act = null;
            if (acounttype == "saving")
            {
                act = new Saving();
            }
            else if(acounttype == "current")
            {
                act = new Current();
            }
            else if(acounttype=="loan")
            {
                act = new Loan();
            }
            
            act.AccountNumber = actno;
            result = act.deposit(amt);
            result1 = act.ShowBalance();
            
           Console.WriteLine(result);
           Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
