using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public void WithDraw(double amount)
        {
            if( amount > WithdrawLimit)
            {
                throw new Exception("Values superior of the Limit withdraw.");
            }
            if(amount > Balance)
            {
                throw new Exception("Value superior of the balance.");
            }

            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
