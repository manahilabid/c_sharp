using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        public class Account
        {
            public int accountnumber {  get; set; }
            public string customerName { get; set; }
            public double balance { get; set; }

            public Account(int Accountnumber , string Customername, string Balance)
            {
                accountnumber = Accountnumber;
                customerName = Customername;
                 double balance;
            }
            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine("Deposit successful. New balance "+balance);
;            }
            public void withdraw(double amount)
            {
                if (balance >= amount )
                {
                    balance -= amount;
                    Console.WriteLine("with drawl successful.new balance"+balance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance!");
                }
         
            }
            public void display()
            {
                Console.WriteLine($"Account NO {accountnumber}, Name {customerName} , Balance{balance}");
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
