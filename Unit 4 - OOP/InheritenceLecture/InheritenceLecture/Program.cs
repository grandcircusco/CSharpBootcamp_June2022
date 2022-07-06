// See https://aka.ms/new-console-template for more information
using InheritenceLecture;

BankAccount b = new BankAccount(1, 10, "Name", "Home");
CheckingsAccount c = new CheckingsAccount(2, 10, "Name", "Home", 100);
SavingsAccount s = new SavingsAccount(3, 10, "Name", "Home", .1);

Console.WriteLine(b.Balance);
b.Withdraw(11);
Console.WriteLine(b.Balance);
Console.WriteLine($"Bank Audit: {Audit(b)}");

Console.WriteLine();

Console.WriteLine(c.Balance);
c.Withdraw(11);
Console.WriteLine(c.Balance);
Console.WriteLine($"Checking Audit: {Audit(c)}");

Console.WriteLine();

Console.WriteLine(s.Balance);
s.Withdraw(11);
Console.WriteLine(s.Balance);
s.Deposit(100);
Console.WriteLine(s.Balance);
Console.WriteLine($"Savings Audit: {Audit(s)}");

//Polymorphism in arrays/collections
List<BankAccount> myAccounts = new List<BankAccount>();
myAccounts.Add(b);
myAccounts.Add(c);
myAccounts.Add(s);
foreach (BankAccount acc in myAccounts)
{
    acc.Deposit(50);
    Console.WriteLine(acc.Balance);
}


//Methods
//polymorphism allows us to send any bank account(or children) through method
static bool Audit(BankAccount account)
{
    if(account.Balance >=1  && account.AccountNumber >= 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}