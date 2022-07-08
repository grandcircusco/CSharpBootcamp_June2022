using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    //Adding abstract does not allow you to make an instance
    internal abstract class BankAccount
    {
        //properties
        public double Balance { get; set; }
        public string CustomerName { get; set; }
        //methods
        //abstract method forces child to make functionality
        public abstract void Withdraw(double money);
        //Abstract classes can have normal methods
        public void Deposit(double money)
        {
            Balance += money;
        }
    }
}
