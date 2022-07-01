Console.WriteLine("Welcome to GC Dice roller!");
Console.WriteLine("How many sides should each die have?");

//Run all dice combos to confirm they work
//Tester();

//validate input as number
int sides = 0;

//making sure number is within range
while (true)
{
    //only loops if not parsable
    while (!int.TryParse(Console.ReadLine(), out sides))
    {
        Console.WriteLine("Invalid format. Try again.");
    }
    if(sides < 1)
    {
        Console.WriteLine("Out of range. Try again.");
    }
    else
    {
        break;
    }
}

//while (true)
//{
//    try
//    {
//        sides = int.Parse(Console.ReadLine());
//        if (sides < 1)
//        {
//            Console.WriteLine("Out of range. Try again");
//        }
//        else
//        {
//            //valid input
//            break;
//        }
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}


//Rolling dice section
bool RollingDice = true;
while (RollingDice)
{
    int roll1 = getRandom(sides);
    int roll2 = getRandom(sides);
    Console.WriteLine($"Roll 1:{roll1}  Roll 2:{roll2}  Total:{roll1 + roll2}");
    if(sides == 6)
    {
        Console.WriteLine(getSixSidedDiceCombos(roll1, roll2));
        Console.WriteLine(getSixSidedDiceTotals(roll1, roll2));
    }
    else if(sides == 20)
    {
        Console.WriteLine(getTwentySidedDiceCombos(roll1, roll2));
    }
    //ask if they want to keep looping
    while (true)
    {
        Console.WriteLine("Would you like to keep rolling? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            //keep looping
            break;
        }
        else if (choice == "n")
        {
            //stop looping
            RollingDice = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}





//Methods

//Getting random numbers
static int getRandom(int max)
{
    Random random = new Random();
    return random.Next(max) + 1; //if max is 6, this returns 0-5. Add 1 so it becomes 1-6
    
}

static string getSixSidedDiceCombos(int d1, int d2)
{
    if(d1 == 1 && d2 == 1)
    {
        return "Snake Eyes";
    }
    else if((d1 == 1 && d2 == 2) || (d1 == 2 && d2 == 1))
    {
        return "Ace Deuce";
    }
    else if(d1 == 6 && d2 == 6)
    {
        return "Box Cars";
    }
    else
    {
        return "";
    }
}

static string getSixSidedDiceTotals(int d1, int d2)
{
    if (d1 + d2 == 7 || d1 + d2 == 11)
    {
        return "Win";
    }
    else if (d1 + d2 == 2 || d1 + d2 == 3 || d1 + d2 == 12)
    {
        return "Craps";
    }
    else
    {
        return "";
    }
}

static string getTwentySidedDiceCombos(int d1, int d2)
{
    if(d1 == 20 && d2 == 20)
    {
        return "Super Crit";
    }
    else if (d1 == 20 || d2 == 20)
    {
        return "Crit";
    }
    else if(d1 == 1 && d2 == 1)
    {
        return "Super Failure";
    }
    else if (d1 == 1 || d2 == 1)
    {
        return "Failure";
    }
    else
    {
        return "";
    }
}

static void Tester() 
{
    //snake eyes
    Console.WriteLine(getSixSidedDiceCombos(1,1));
    //ace deuce
    Console.WriteLine(getSixSidedDiceCombos(1, 2));
    Console.WriteLine(getSixSidedDiceCombos(2, 1));
    //box cars
    Console.WriteLine(getSixSidedDiceCombos(6, 6));
    //win
    Console.WriteLine(getSixSidedDiceTotals(1, 6));
    Console.WriteLine(getSixSidedDiceTotals(5, 6));
    //craps
    Console.WriteLine(getSixSidedDiceTotals(1, 1));
    Console.WriteLine(getSixSidedDiceTotals(1, 2));
    Console.WriteLine(getSixSidedDiceTotals(6, 6));
    //DND DICE
    //super crit
    Console.WriteLine(getTwentySidedDiceCombos(20,20));
    //crit
    Console.WriteLine(getTwentySidedDiceCombos(1, 20));
    Console.WriteLine(getTwentySidedDiceCombos(20, 1));
    //super failures
    Console.WriteLine(getTwentySidedDiceCombos(1, 1));
    //failure
    Console.WriteLine(getTwentySidedDiceCombos(2, 1));
    Console.WriteLine(getTwentySidedDiceCombos(1, 2));
}
