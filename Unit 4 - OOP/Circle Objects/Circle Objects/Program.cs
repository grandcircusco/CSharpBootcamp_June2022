using Circle_Objects;

Console.WriteLine("Welcome to circle tester.");
//program loop
bool runProgram = true;
//int counter = 0;
List<Circle> allCircles = new List<Circle>();

while (runProgram)
{
    //get radius
    double radius = 0;
    Console.WriteLine("Please enter a radius");
    while (true)
    {
        while (!double.TryParse(Console.ReadLine(), out radius))
        {
            //not a number
            Console.WriteLine("Invalid input. Try again");
        }
        if (radius <= 0)
        {
            //too low
            Console.WriteLine("That value is too low. Try again.");
        }
        else
        {
            //passing value
            break;
        }
    }
    //Circles
    //creating new circle
    Circle c = new Circle(radius);
    //counter++;
    allCircles.Add(c);

    Console.WriteLine($"Area: {c.CalculateFormattedArea()}");
    Console.WriteLine($"Circumference: {c.CalculateFormattedCircumference()}");

    //getting out of loop
    runProgram = Validator.Validator.GetContinue("Would you like to create another circle?");
    //while (true)
    //{
    //    Console.WriteLine("Would you like to create another circle? y/n");
    //    string choice = Console.ReadLine().ToLower().Trim();
    //    if(choice == "y")
    //    {
    //        break;
    //    }
    //    else if(choice == "n")
    //    {
    //        runProgram = false;
    //        break;
    //    }
    //    else
    //    {
    //        Console.WriteLine("That was not valid");
    //    }
    //}
}

//Console.WriteLine($"Goodbye! You create {counter} circles");
Console.WriteLine($"Goodbye! You create {allCircles.Count} circles");