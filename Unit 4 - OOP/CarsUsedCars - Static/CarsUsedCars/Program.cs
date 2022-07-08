using CarsUsedCars;

//Main Program
Console.WriteLine("Welcome to GC Car Shop!");
bool runProgram = true;
while (runProgram)
{
    Car.ListCars();
    //Getting user choice
    int choice = GetChoice(Car.Cars.Count);//-1 is add car, all others is buy

    Car.DisplayDetails(choice);

    Car.RemoveCars(choice);
    
    runProgram = GetContinue();
}



//Methods

static bool GetContinue()
{
    bool result = true;

    while (true)
    {
        Console.WriteLine("Would you like to buy another car? y/n");
        string choice = Console.ReadLine().Trim().ToLower();
        if(choice == "y")
        {
            result = true;
            break;
        }
        else if (choice == "n")
        {
            result= false;
            break;
        }
        else
        {
            Console.WriteLine("Not valid. Try again");
        }
    }

    return result;
}

static int GetChoice(int count)
{
    Console.WriteLine($"Please choose a car to buy. 0-{count}");
    int result = 0;
    while (true)
    {
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Not a valid input. Try again");
        }
        if(result < 0 || result > count)
        {
            Console.WriteLine("Not valid choices");
        }
        else
        {
            //valid input
            break;
        }
    }
    
    //minus 1 so value is index. If they choose to add a car, it will be -1
    return result - 1;
}





