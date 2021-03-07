using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio4.Class
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public double Cash { get; private set; }

        public BankAccount(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public BankAccount(int number, string name, double cash) : this(number, name)
        {
            Cash = cash;
        }

        public void Deposit(double amount)
        {
            Cash += amount;
        }

        public void Withdraw(double amount)
        {
            Cash -= amount + 5;
        }

        public override string ToString()
        {
            return ($"On account {Number} \nThat belongs to {Name} \nHave the balance of {Cash}");
        }
    }
}
