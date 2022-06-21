/* Name: Justin
 * Date: 06/21/2022
 */


// This is a comment

int MyAge;

//const tells c# this cannot change
const double TaxRate = 0.06;

//Area of Circle
Console.WriteLine("Enter a radius:");


//string entry = Console.ReadLine();
//double value = double.Parse(entry);
//This code combines both steps
double value = double.Parse(Console.ReadLine());

//get area
//double area = 3.141527 * value * value;
double area = Math.PI * Math.Pow(value, 2);

Console.WriteLine(area);

//Basic Arithmetic
//Adding
double x = 5 + 3;
Console.WriteLine(x);
//subtracting
x = 5 - 3;
Console.WriteLine(x);
//multiply
x = 5 * 3;
Console.WriteLine(x);
//divide
x = 5 / 3;
Console.WriteLine(x);
//Modulus
x = 5 % 3;
Console.WriteLine(x);
double odd = 9 % 2;
Console.WriteLine(odd);
//Increment
x = 100;
//x = x + 1;
x++;
Console.WriteLine(x);
//Decrement
//x = x - 1;
x--;
Console.WriteLine(x);
//negative number
x = -50;
Console.WriteLine(x);

//Assignments
int y = 100;
Console.WriteLine(y);

//addition assignment
y += 5;
Console.WriteLine(y);

//substraction assignment
y -= 15;
Console.WriteLine(y);

//multiply assignment
y *= 2;
Console.WriteLine(y);

//divide assignment
y /= 3;
Console.WriteLine(y);

//modulus assignment
y %= 2;
Console.WriteLine(y);