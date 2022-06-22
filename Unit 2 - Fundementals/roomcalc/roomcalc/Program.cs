Console.WriteLine("Welcome to the room calculator.");

//ask for values
Console.WriteLine("Please enter the length of the room.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room.");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of the room.");
double height = double.Parse(Console.ReadLine());

//Calculations
double area = length * width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * ((width * length) + (height * length) + (height * width));

//Display Results
Console.WriteLine("Area:" + area);
Console.WriteLine("Perimeter:" + perimeter);
Console.WriteLine("Volume:" + volume);
Console.WriteLine("Surface Area:"+ surfaceArea);

//Size of room
//small room
if(area <= 250)
{
    Console.WriteLine("This is a small room");
}
//medium room
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium room");
}
//large room
else if (area >= 650)
{
    Console.WriteLine("This is a large room");
}