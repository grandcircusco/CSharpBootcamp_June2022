//Boolean Expressions
Console.WriteLine(1 > 0);

int age = 24;

Console.WriteLine(age <= 21);
Console.WriteLine(age >= 21);
Console.WriteLine(age > 100);
Console.WriteLine(age < 1);
Console.WriteLine(age == 50);
Console.WriteLine(age >= 60 && age <= 120);
Console.WriteLine(age >= 60 || age <= 13);
Console.WriteLine(age != 15);

string name = "Justin";
Console.WriteLine(name == "Justin");
Console.WriteLine(name == "justin");
Console.WriteLine(name == "JUSTIN");

//If statement

if(age >= 21)
{
    Console.WriteLine("You can drink!");
}
else if (age >= 18)
{
    Console.WriteLine("You can vote!");
}
else if(age >= 16)
{
    Console.WriteLine("You can drive!");
}
else
{
    Console.WriteLine("You are too young.");
}
//-----------------------------------------
if (age >= 21)
{
    Console.WriteLine("You can drink!");
}

if (age >= 18)
{
    Console.WriteLine("You can vote!");
}

if (age >= 16)
{
    Console.WriteLine("You can drive!");
}
else
{
    Console.WriteLine("You are too young.");
}

//Switch
int currentDefcon = 6;

switch (currentDefcon)
{
    case 1:
        Console.WriteLine("Nukes are flying");
        break;
    case 2:
        Console.WriteLine("Very close to nukes");
        break;
    case 3:
        Console.WriteLine("Air force is ready");
        break;
    case 4:
        Console.WriteLine("Be alert!");
        break;
    case 5:
        Console.WriteLine("Normal readiness");
        break;
    default:
        Console.WriteLine("Unknown Defcon");
        break;
}

//Ternary
bool isOwner = (name == "Justin") ? true : false;
Console.WriteLine("Is " + name + " the owner?" + isOwner);

//Temp Exercise
Console.WriteLine("What is the temperature");
int temperature = int.Parse(Console.ReadLine());
Console.WriteLine("Is this in F or C? F/C");
string choice = Console.ReadLine();
if (choice == "F")
{
    double convert = (temperature - 32) / 1.8;
    Console.WriteLine(convert);
}
else if (choice == "C")
{
    double convert = (temperature * 1.8) + 32;
    Console.WriteLine(convert);
}

//Loops
//While Loop
int loops = 0;
while(loops <= 10)
{
    Console.WriteLine(loops);
    loops++;
}

while (true)
{
    Console.WriteLine("Do you want to stop?");
    string loopChoice = Console.ReadLine();
    if(loopChoice == "yes" || loopChoice == "y")
    {
        break;
    }
}

//Do While
int counter = 10;
do
{
    Console.WriteLine(counter);
    counter--;
} while (counter > 0);

//for loop
for(int i = 0; i<=10; i++)
{
    Console.WriteLine(i);
}

for(int i = 10; i>=0; i--)
{
    Console.WriteLine(i);
}

int price = 5;
int quantity = 15;
int total = 0;
for(int i = 0; i < quantity; i++)
{
    total += price;
}
Console.WriteLine("Your total is:" + total);

//foreach loop
int[] nums = { 1, 5, 4, 3, 6, 10, 0 ,5};
foreach(int n in nums)
{
    Console.WriteLine(n);
}