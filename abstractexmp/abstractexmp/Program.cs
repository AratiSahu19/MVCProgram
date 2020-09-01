using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractexmp
{
   abstract class Account
    {
        public int AccountNo { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 1000;

        }

        public abstract string deposit(double amount);
       

        public string Show(int accountn)
        {

            return " successful Balance of Account no:" + accountn + "is:" + Balance;
        }
    }
    class Saving : Account
    {


        public override string deposit(double amount)
        {
            double Interest = 500;
            Balance = Balance + amount + Interest;
            return "Balance of account no:" + AccountNo + "is:" + Balance;
        }

    }
    class Current : Account
    {
        public override string deposit(double amount)
        {
            Balance = Balance + amount;
            return "Balance of account no:" + AccountNo + "is:" + Balance;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
          
            int actno;
            double Amount;
            string result = null, result1 = null;
            Console.WriteLine("enter the account no");
            actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount to deposit");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose the account=saving or current");
            string type = Console.ReadLine();
            Account act = null;
            if (type == "Saving")
            {
                act = new Saving();
            }
            else if (type == "current")
            {
                act = new Current();
            }
            act.AccountNo = actno;

            result = act.deposit(Amount);
            result1 = act.Show(actno);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
