using System;

namespace Delegate_event
{
    public class Account
    {
        public int balance = 1000;

       

        public  string deposit(int amount)
        {
            balance = balance + amount;
            return "Amount deposited is :" + balance;
        }
        public string withdraw(int amount)

        {
            balance = balance - amount;
            return "Amount withdraw"+balance;

        }
    }
    
  
    class Program
    {
        public delegate string accountdelegate(int amount);
        private event accountdelegate accountevent;
        static void Main(string[] args)
        {
            Program p = new Program();
            int acc_no, amount;
            Console.WriteLine("Enter Account Number");
            acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose one account saving or current");
            string atype = Console.ReadLine();
            Account ac = new Account();
            accountdelegate ad = null;
            if (atype == "saving")
            {

                p.accountevent += new accountdelegate(ac.deposit);
            }
            else if (atype == "current")
            {
                p.accountevent += new accountdelegate(ac.withdraw);

            }
            string result = p.accountevent(amount);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
