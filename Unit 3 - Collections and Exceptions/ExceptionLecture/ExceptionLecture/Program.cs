using System.Net.Mail;
using System.Text.RegularExpressions;
//This causes an exceptions
//int broken = int.Parse("Justin");

//Catch an exception

//try catch allows for 100% control
//creating variable outside to have access

double subtotal = 0.0;
try
{
    Console.WriteLine("Enter subtotal:");
    subtotal = double.Parse(Console.ReadLine());
    if (subtotal < 0)
    {
        throw new Exception("Subtotal cannot be lower than 0");
    }
}
catch (FormatException e)//only covers incorrect formats
{
    Console.WriteLine("Error! Invalid number.");
}
catch (Exception e)//Exception covers all exceptions
{
    Console.WriteLine(e.Message);
}


//Built in methods that handle everything
double price;
Console.WriteLine("Please enter a price for the order");
if (double.TryParse(Console.ReadLine(), out price))
{
    Console.WriteLine($"Your order is ${price}");
}
else
{
    Console.WriteLine("Could not convert");
}

//Regex
//@"" for a pattern
if (Regex.IsMatch("Hdf423", @"(?:[a-zA-Z|\d][- ]?){3}"))
{
    Console.WriteLine("Is a match");
}
else
{
    Console.WriteLine("Not a match");
}


//Exercises
int result = 0;//default value
while (true)
{
    try
    {
        Console.WriteLine("Please enter a number 0 - 100");
        result = int.Parse(Console.ReadLine());
        if (result < 0 || result > 100)
        {
            //out of range
            throw new Exception("That number was out of range");
            //Achieves same thing without throwing error. I threw this error for example purposes
            //Console.WriteLine("That number was out of range");
        }
        else
        {
            //in range and a number
            break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Data must be a number");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine(result);

//exercise 1 v2
int result2 = 0;
Console.WriteLine("Please enter a number 0 - 100");
while (true)
{
    while (int.TryParse(Console.ReadLine(), out result2) == false)
    {
        //wrong format
        Console.WriteLine(result2);
        Console.WriteLine("That was not a number");
    }
    if (result2 > 100 || result2 < 0)
    {
        //out of range
        Console.WriteLine("This number is out of range");
    }
    else
    {
        //in range
        break;
    }
}
Console.WriteLine(result2);

//Exercise 2

Console.WriteLine("Please enter an email.");
string email = Console.ReadLine();

if (Regex.IsMatch(email, @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"))
{
    Console.WriteLine("Is email");
}
else
{
    Console.WriteLine("Not email");
}

//Connor's email version
//https://stackoverflow.com/a/1903368
try
{
    email = new MailAddress(email).Address;
    Console.WriteLine("is email");
    Console.WriteLine(email);
}
catch (FormatException)
{
    // address is invalid
    Console.WriteLine("Not Email");
}

//Quick Demo
//Assigned to get user input and make sure its a positive number
int result = 0;
Console.WriteLine("Please enter a positive number");
while (true)
{
    try
    {
        result = int.Parse(Console.ReadLine());
        if (result < 0)
        {
            Console.WriteLine("This is not positive");
        }
        else
        {
            break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}

Console.WriteLine(result);

//Logical Error
//check if x is larger than y
int x = 3;
int y = 4;
if (x < y)
{
    Console.WriteLine("x is larger");
}