using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class CheckingsAccount : BankAccount
    {
        //property
        public double OverdraftFee { get; set; }

        //constructor
        public CheckingsAccount(int _accountNumber, double _balance, string _customerName, string _customerAddress, double _overdraftFee) : base(_accountNumber, _balance, _customerName, _customerAddress)
        {
            OverdraftFee = _overdraftFee;
        }
        //Methods
        public override void Withdraw(double money)
        {
            Balance -= money;
            if(Balance < 0)
            {
                Balance -= OverdraftFee;
            }
        }
    }
}
