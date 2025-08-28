using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Details
{
    internal class Account
    {
        public string AccountHolder;
        public double Balance;

        public Account(string name , double balance)
        {
            this.AccountHolder = name;
            this.Balance = balance;
        }
        public virtual void widthdraw(double amount)
        {
            if (amount<=Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Accountholder: {AccountHolder} WidthDraw: {amount} Remaining Balance: {Balance} ");

            }
            else
            {
                Console.WriteLine("Not enough Balance");
            }
        }
    }
    class SavingAccount : Account
    {
        public SavingAccount(string name, double balance) : base(name, balance) { }
    }
}
