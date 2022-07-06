using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount(int _accountNumber, double _balance, string _customerName, string customerAddress, double _interestRate) : base(_accountNumber, _balance, _customerName, customerAddress)
        {
            InterestRate = _interestRate;
        }

        //methods
        public override void Deposit(double money)
        {
            Balance += money;
            Balance += (Balance * InterestRate);
        }
        public override void Withdraw(double money)
        {
            if(money >= Balance)
            {
                Console.WriteLine("Withdraw too large");
            }
            else
            {
                Balance -= money;
            }
        }
    }
}
