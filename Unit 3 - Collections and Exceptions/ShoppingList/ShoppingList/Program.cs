Dictionary<string, decimal> store = new Dictionary<string, decimal>()
{
    ["Chips"] = 1.50M,
    ["Cola"] = 1.99M,
    ["Candy"] = 1.00M,
    ["Chocolate"] = 2.00M,
    ["Protien Bar"] = 4.00M,
    ["Water"] = 1.00M,
    ["Juice"] = 1.99M,
    ["Slushie"] = 1.33M,
    ["Gas"] = 15.78M
};
List<string> cart = new List<string>();

//Start
Console.WriteLine("Welcome to the GC Gas Station.");

//Display Items
Console.WriteLine(string.Format("{0,-15}{1,15}", "Item", "Cost"));
Console.WriteLine(string.Format("{0,-15}{1,15}", "====", "===="));
int i = 0;
foreach (KeyValuePair<string, decimal> kvp in store)
{
    Console.WriteLine(string.Format("{0,-15}{1,15}",$"{i}. {kvp.Key}", kvp.Value));
    i++;
}
//Empty space for looks
Console.WriteLine();

bool buyingItems = true;
while(buyingItems)
{
    //Get Item
    Console.WriteLine("Please enter the name or the number of the item you want to buy!");
    string choice = Console.ReadLine();

    //value used in tryParse if parse is successful
    int menuIndex = -1;

    //Check if item exists
    if (store.ContainsKey(choice))
    {
        //Item exists
        cart.Add(choice);
    }
    //return true if input can be parse or false if it cannot
    //out value contains int version of input
    else if (int.TryParse(choice, out menuIndex))
    {
        //Look at dictionary, uses index to retrieve associated key
        cart.Add(store.Keys.ElementAt(menuIndex));
    }
    else
    {
        //Item does not exist
        Console.WriteLine("Item not sold here. Try again");
        //don't want the user to stop if they misclicked
        continue;
    }

    //ask to stop buying items
    while (true)
    {
        Console.WriteLine("Would you like to stop buying items? y/n");
        string loopChoice = Console.ReadLine().ToLower().Trim();
        
        if(loopChoice == "y")
        {
            //want to stop
            buyingItems = false;
            break;
        }
        else if(loopChoice == "n")
        {
            //doesn't want to stop
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}


//Display Cart
Console.WriteLine("Thank you for shopping at GC Gas Station.");
Console.WriteLine("Here is your receipt");

//data 
decimal total = 0;
string highest = cart[0];
string lowest = cart[0];

Console.WriteLine(string.Format("{0,-15}{1,15}", "Item", "Cost"));
Console.WriteLine(string.Format("{0,-15}{1,15}", "====", "===="));

//Each item is just a key in the dictionary
//loop through the keys and use it in dictionary to get value
foreach(string item in cart.OrderByDescending(i => store[i])) //Uses linq to order by store values
{
    Console.WriteLine(string.Format("{0,-15}{1,15}", item, store[item]));
    total += store[item];

    //check if item cost more than highest
    if(store[item] > store[highest])
    {
        highest = item;
    }
    else if(store[item] < store[lowest])
    {
        lowest = item;
    }
}
Console.WriteLine(string.Format("{0,-15}{1,15}", "====", "===="));
Console.WriteLine(string.Format("{0,-15}{1,15}", "Total", total));
Console.WriteLine();
Console.WriteLine($"Your highest price was {highest} and the lowest was {lowest}");