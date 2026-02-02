using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion3_iti
{
    internal class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Error: Balance cannot be negative");
                else
                    balance = value;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Error: Deposit amount must be positive");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdraw amount must be positive");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Error: Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }

    }
}
