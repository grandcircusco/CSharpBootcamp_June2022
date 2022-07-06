using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class BankAccount
    {
        //properties
        public int AccountNumber { get; }//Only use get; if you want it read only
        public double Balance { get; set; } 
        public string CustomerName { get; set; } //Allows for reading and writing
        public string CustomerAddress { get; set; }//Allows for reading and writing

        //Constructor
        public BankAccount(int _accountNumber, double _balance, string _customerName, string customerAddress)
        {
            AccountNumber = _accountNumber;
            Balance = _balance;
            CustomerName = _customerName;
            CustomerAddress = customerAddress;
        }

        //Methods
        //virutal means a child class can change functionality
        public virtual void Deposit(double money)
        {
            Balance += money;
        }
        public virtual void Withdraw(double money)
        {
            Balance -= money;
        }
    }
}
