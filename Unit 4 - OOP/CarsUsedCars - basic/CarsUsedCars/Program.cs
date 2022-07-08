using CarsUsedCars;

List<Car> Cars = new List<Car>()
{
    new Car("Tesla", "Model S", 2022, 60000),
    new UsedCar("Cardboard Box", "Shipping", 2016, 15, 100),
    new Car("Jeep", "Wrangler", 2023, 79000),
    new UsedCar("Chevy", "Sonic", 2015, 15000, 68900),
    new UsedCar("Dodge", "Durango", 2018, 17800, 150000),
    new Car("Ford", "Bronco Sport", 2023, 68000),
    new UsedCar("Flintstones", "'ol reliable", 2, 500, 600000),
    new UsedCar("Nature's Finest", "Rock", 0, 0, 600000),

};

//Main Program
Console.WriteLine("Welcome to GC Car Shop!");
bool runProgram = true;
while (runProgram)
{
    ListCars(Cars);
    //Getting user choice
    int choice = GetChoice(Cars);//all others is buy

    DisplayDetails(Cars[choice]);

    Cars = RemoveCars(Cars, choice);

    runProgram = GetContinue();
}



//Methods

static void DisplayDetails(Car c)
{
    Console.WriteLine($"You have chosen a {c.Year} {c.Make} {c.Model}");
}

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

static int GetChoice(List<Car> Cars)
{
    Console.WriteLine($"Please choose a car to buy. 1-{Cars.Count}");
    int result = 0;
    while (true)
    {
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Not a valid input. Try again");
        }
        if(result <= 0 || result > Cars.Count)
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


static void ListCars(List<Car> Cars)
{
    for(int i = 0; i < Cars.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {Cars[i].ToString()}");
    }
}


static List<Car> RemoveCars(List<Car> Cars, int index)
{
    Cars.RemoveAt(index);
    return Cars;
}