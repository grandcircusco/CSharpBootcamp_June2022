using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(double _balance, string _customerName)
        {
            Balance = _balance;
            CustomerName = _customerName;
        }
        public override void Withdraw(double money)
        {
            if(money > Balance)
            {
                Console.WriteLine("Withdrawing too much");
            }
            else
            {
                Balance -= money;
            }
        }
    }
}
