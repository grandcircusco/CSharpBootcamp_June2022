using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class CheckingsAccount : BankAccount
    {
        //properties
        public double OverDraftFee { get; set; }
        //Constructor
        public CheckingsAccount(double _balance, string _customerName, double _overdraftFee)
        {
            Balance = _balance;
            CustomerName = _customerName;
            OverDraftFee = _overdraftFee;
        }

        public override void Withdraw(double money)
        {
            //Allow user to go negative
            Balance -= money;
            if(Balance < 0)
            {
                Balance -= OverDraftFee;
            }
        }
    }
}
