using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_system
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string customerName, double balance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful. New Balance: " + Balance);
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful. New Balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber}, Name: {CustomerName}, Balance: {Balance}");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Hardcoded admin credentials
            string adminUser = "manahil";
            string adminPass = "khani1234";

            int loginAttempts = 0;
            bool isLoggedIn = false;

            // Login system
            while (loginAttempts < 3 && !isLoggedIn)
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (username == adminUser && password == adminPass)
                {
                    Console.WriteLine("Login Successful!\n");
                    isLoggedIn = true;
                }
                else
                {
                    loginAttempts++;
                    Console.WriteLine("Invalid credentials! Attempts left: " + (3 - loginAttempts));
                }
            }

            if (!isLoggedIn)
            {
                Console.WriteLine("Too many failed attempts. Exiting program...");
                return;
            }

            // Array to store accounts
            Account[] accounts = new Account[10];
            int accountCount = 0;

            // Main menu loop
            int choice;
            do
            {
                Console.WriteLine("\n===== Bank Management System =====");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. View Accounts");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");l
                Console.WriteLine("5. Search Account by Name");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (accountCount < 10)
                        {
                            Console.Write("Enter Account Number: ");
                            int accNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Customer Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Initial Balance: ");
                            double balance = Convert.ToDouble(Console.ReadLine());

                            accounts[accountCount] = new Account(accNo, name, balance);
                            accountCount++;
                            Console.WriteLine("Account created successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Maximum account limit reached (10).");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- All Accounts ---");
                        for (int i = 0; i < accountCount; i++)
                        {
                            accounts[i].DisplayDetails();
                        }
                        break;

                    case 3:
                        Console.Write("Enter Account Number for Deposit: ");
                        int depNo = Convert.ToInt32(Console.ReadLine());
                        bool foundDep = false;

                        for (int i = 0; i < accountCount; i++)
                        {
                            if (accounts[i].AccountNumber == depNo)
                            {
                                Console.Write("Enter Deposit Amount: ");
                                double depAmt = Convert.ToDouble(Console.ReadLine());
                                accounts[i].Deposit(depAmt);
                                foundDep = true;
                                break;
                            }
                        }
                        if (!foundDep)
                            Console.WriteLine("Account not found!");
                        break;

                    case 4:
                        Console.Write("Enter Account Number for Withdrawal: ");
                        int witNo = Convert.ToInt32(Console.ReadLine());
                        bool foundWit = false;

                        for (int i = 0; i < accountCount; i++)
                        {
                            if (accounts[i].AccountNumber == witNo)
                            {
                                Console.Write("Enter Withdrawal Amount: ");
                                double witAmt = Convert.ToDouble(Console.ReadLine());
                                accounts[i].Withdraw(witAmt);
                                foundWit = true;
                                break;
                            }
                        }
                        if (!foundWit)
                            Console.WriteLine("Account not found!");
                        break;

                    case 5:
                        Console.Write("Enter Customer Name to Search: ");
                        string searchName = Console.ReadLine();
                        bool foundName = false;

                        for (int i = 0; i < accountCount; i++)
                        {
                            if (accounts[i].CustomerName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                accounts[i].DisplayDetails();
                                foundName = true;
                            }
                        }
                        if (!foundName)
                            Console.WriteLine("No account found with that name!");
                        break;

                    case 6:
                        Console.WriteLine("Exiting program... Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 6);
        }

    }
}