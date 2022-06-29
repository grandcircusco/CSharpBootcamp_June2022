string[] names = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] foods = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
string[] town = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

Console.WriteLine("Welcome to the student DB");

//create outside of loop to have access
int choice = -1;

bool runProgram = true;
while (runProgram)
{
    //Loop until valid input
    while (true)
    {
        Console.WriteLine($"Please choose a number between 1-{names.Length} or type a students name. Type 'list' if you want to see all students");
        
        string option = Console.ReadLine();
        if (option.Contains("list"))
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]}");
            }
            continue;
        }
        //name search
        for(int i = 0; i < names.Length; i++)
        {
            if (names[i].ToLower().Contains(option))
            {
                //add 1 because logic below removes the 1
                choice = i + 1;
                break;
            }
        }

        //Parse user choice if not 'list' or a name
        if (choice == -1)
        {
            choice = int.Parse(option);
        }
        //invalid
        if (choice < 1 || choice > names.Length)
        {
            Console.WriteLine("Out of range");
        }
        //valid
        else
        {
            //once value is confirmed, reduce it by one so its an index
            choice--;
            break;
        }
    }

    //display info
    Console.WriteLine($"You chose {names[choice]}");

    //category
    while (true)
    {
        Console.WriteLine("What would you like to know? hometown/favorite food");
        string category = Console.ReadLine().ToLower().Trim();

        //home or town
        //home, hometown, town, Hey google please tell me their town
        if (category.Contains("home") || category.Contains("town"))
        {
            Console.WriteLine($"{names[choice]} is from {town[choice]}");
            break;
        }
        else if (category.Contains("food") || category.Contains("favorite"))
        {
            Console.WriteLine($"{names[choice]}'s favorite food is {foods[choice]}");
            break;
        }
        else
        {
            Console.WriteLine("That category is not valid. Try again.");
        }
    }

    //Continue?
    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string loopChoice = Console.ReadLine().ToLower().Trim();
        if (loopChoice == "y")
        {
            //continue running
            break;
        }
        else if (loopChoice == "n")
        {
            //stop running
            runProgram = false;
            break;
        }
        else
        {
            //invalid
            Console.WriteLine("That was not y/n");
        }
    }
}

