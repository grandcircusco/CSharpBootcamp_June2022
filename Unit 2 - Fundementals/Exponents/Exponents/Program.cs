Console.WriteLine("Welcome to the Exponents lab");

bool runProgram = true;

while(runProgram)
{
    Console.WriteLine("Please enter a positive number. 1 - 1290");
    int choice = int.Parse(Console.ReadLine());
    if (choice > 1290 || choice < 1)
    {
        continue;
    }

    //Alternate Validation loop
    //Console.WriteLine("Please enter a positive number. 1 - 1290");
    //int choice = 0;
    //while (true)
    //{
    //    choice = int.Parse(Console.ReadLine());
    //    if (choice >=1 && choice <= 1290)
    //    {
    //        break;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Out of range.");
    //    }
    //}


    //Header
    //Console.WriteLine("Number\tSquared\tCubed");
    Console.WriteLine(String.Format("{0,15} | {1,15} | {2,15}", "Number", "Squared", "Cubed"));
    //Console.WriteLine("=====\t=====\t=====");
    Console.WriteLine(String.Format("{0,15} | {1,15} | {2,15}", "=====", "=====", "====="));
    //loop to print numbers
    for (int i = 1; i <= choice; i++)
    {
        //Console.WriteLine(i + "\t" + getSquared(i) + "\t" + getCubed(i));
        Console.WriteLine(String.Format("{0,15} | {1,15} | {2,15}",i, getSquared(i), getCubed(i)));
    }

    while (true)
    {
        //check if want to still run
        Console.WriteLine("Would you like to continue? y/n");
        string loopChoice = Console.ReadLine();
        if (loopChoice.ToLower().Trim() == "y")
        {
            break;
        }
        else if (loopChoice.ToLower().Trim() == "n")
        {
            runProgram = false;
            break;
        }
    }

}




//Methods
static int getSquared(int x)
{
    return x * x;
}

static int getCubed(int x)
{
    return x * x * x;
}