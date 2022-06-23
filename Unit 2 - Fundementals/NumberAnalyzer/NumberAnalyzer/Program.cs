Console.WriteLine("Welcome to the Number Analyzer.");

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

bool runProgram = true;

while (runProgram)
{
    //create choice before loop to use it outside of loop
    int choice = 0;
    //while true is an infinite loop
    while (true)
    {
        Console.WriteLine(name + ", please enter a number between 1-100");
        choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 100)
        {
            //if condition is met, this breaks out of infinite loop
            break;
        }
    }


    //Analyzing
    //odd
    if (choice < 60 && choice % 2 == 1)
    {
        Console.WriteLine(name + " your answer is:" + choice + " Odd and less than 60");
    }
    else if (choice > 60 && choice % 2 == 1)
    {
        Console.WriteLine(name + " your answer is:" + choice + " Odd and greater than 60");
    }
    //even
    else if (choice >= 2 && choice <= 24)
    {
        Console.WriteLine(name + " your answer is:" + "Even and less than 25");
    }
    else if (choice >= 26 && choice <= 60)
    {
        Console.WriteLine(name + " your answer is:" + "Even and between 26 and 60 inclusive.");
    }
    else if (choice > 60)
    {
        Console.WriteLine(name + " your answer is:" + choice + " Even and greater than 60");
    }

    //get out of loop
    Console.WriteLine("Would you like to continue? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "y")
    {
        //doesn't do anything yet
    }
    else if (loopChoice.ToLower().Trim() == "n")
    {
        runProgram = false;
    }
}