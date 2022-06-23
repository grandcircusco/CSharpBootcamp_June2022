// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string hUser = returnHelloUser("Justin");
Console.WriteLine(hUser);
Console.WriteLine(returnHelloUser("David"));
GreetUser();
CanVote(24);
CanVote(17);
Console.WriteLine(getTaxRate());

double total = 150 + (150 * getTaxRate());
Console.WriteLine($"Grand Total: {total}");

Console.WriteLine(adder(2,9));

//#1
Console.WriteLine(convertMinuteToSeconds(20));
//#2
Console.WriteLine(areaTriangle(10,5));
//#3
Console.WriteLine(convertNegative(3));
Console.WriteLine(convertNegative(-3));
//#4
Console.WriteLine(convertPositive(-5));
Console.WriteLine(convertPositive(5));
//#5
greetUser();

string value = "Jjdfks";
string returnvalue = returnHelloUser(value);
Console.WriteLine(value);
Console.WriteLine(returnvalue);

static string returnHelloUser(string name)
{
    name = name.ToLower();
    string result = $"Hello, {name}.";
    return result;
}

static void GreetUser()
{
    Console.WriteLine("Hello and welcome to Method Lecture");
}

//overloaded
//static void GreetUser(string name)
//{

//}

static void CanVote(int age)
{
    if(age >= 18)
    {
        Console.WriteLine("Can vote");
    }
    else
    {
        Console.WriteLine("Cannot vote");
    }
}

static double getTaxRate()
{
    return 0.06;
}

static double adder(double x, double y)
{
    return x + y;
}

//exercise problems
//1
static int convertMinuteToSeconds(int minutes)
{
    return minutes * 60;
}

//2
static double areaTriangle(double height, double length)
{
    return .5 * length * height;
}

//3
static int convertNegative(int x)
{
    if(x > 0)
    {
        return -x;
    }
    else
    {
        return x;
    }

}

//4
static int convertPositive(int x)
{
    if(x < 0)
    {
        return x * -1;
    }
    else
    {
        return x;
    }
}

//5
static void greetUser()
{
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}");
}

//Pass in by reference
int currentage = 24;
string myNickname = ager(ref currentage);
Console.WriteLine(currentage);
Console.WriteLine(myNickname);

static string ager(ref int age)
{
    age = 75;
    return "Old man";
}

//Random
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());

static int GetRandom()
{
    Random rnd = new Random();
    return rnd.Next(1,7);
}