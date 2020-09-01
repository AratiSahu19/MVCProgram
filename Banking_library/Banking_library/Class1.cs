using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_library
{
    public class Account
    {
        public delegate string accountdelegate(int amt);
        public event accountdelegate accountevent;

        public int Acc_No { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Balance = 1000;
        }

        public virtual string deposit(int amount)
        {
            return "Empty";
        }
        public void show(int AccountNumber)
        {

            Console.WriteLine("Balance of account number:" + AccountNumber + "is" + Balance);
        }
    }
   public class Saving : Account
    {
        public int interest { get; set; }

        public override string deposit(int amount)
        {
            interest = 200;
            Balance = Balance + amount + interest;
            return "Total Amount After deposit amount:" + Balance;
        }

    }
   public class Current : Account
    {
        public override string deposit(int amount)
        {
            Balance = Balance + amount;
            return "Total Amount After deposit amount:" + Balance;
        }

    }
   public class Withdraw : Account
    {
        public override string deposit(int amount)
        {
            if (amount < Balance)
            {
                Balance = Balance - amount;
            }
            else
            {
                Console.WriteLine("You don't have sufficient balance");
                Console.WriteLine("You want to check your balance amount Press Y Otherwise Ignore");
                string ch = Console.ReadLine();
                if(ch=="Y")
                {
                    Console.WriteLine("Your Balance is" + Balance);
                }
            }
            return "Total Amount after withdraw: " + Balance;
            
        }
    }

}

