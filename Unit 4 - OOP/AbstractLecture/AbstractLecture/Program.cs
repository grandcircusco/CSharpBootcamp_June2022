using AbstractLecture;

CheckingsAccount c = new CheckingsAccount(100, "Justin", 50);
Console.WriteLine(c.Balance);
c.Withdraw(101);
Console.WriteLine(c.Balance);

Console.WriteLine();

SavingsAccount s = new SavingsAccount(100, "Justin");
Console.WriteLine(s.Balance);
s.Withdraw(101);
Console.WriteLine(s.Balance);

//Polymorphism in list
List<BankAccount> accounts = new List<BankAccount>();
accounts.Add(c);
accounts.Add(s);

foreach(BankAccount acc in accounts)
{
    acc.Deposit(100);
    Console.WriteLine(acc.Balance);
    Console.WriteLine(IsBalancePositive(acc));
}

//Methods
static bool IsBalancePositive(BankAccount acc)
{
    return acc.Balance > 0;
}