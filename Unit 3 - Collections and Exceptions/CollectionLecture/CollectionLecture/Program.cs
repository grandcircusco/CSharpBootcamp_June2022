using System.Collections;

//normal list
List<string> names = new List<string>();
names.Add("Justin");
//not allowed
//names.Add(1);
foreach(string n in names)
{
    Console.WriteLine(n);
}

//Alternet list creating
List<string> staff = new List<string>()
{
    "Billy",
    "Damien",
    "Justin",
    "Josh"
};
Console.WriteLine(staff[1]);
Console.WriteLine(staff.Count);
//List Methods
staff.Insert(2, "Ali");
foreach(string s in staff)
{
    Console.WriteLine(s);
}
//staff.RemoveAt(2);
staff.Remove("Ali");
foreach (string s in staff)
{
    Console.WriteLine(s);
}

//Dictionaries
Dictionary<string, bool> tasty = new Dictionary<string, bool>();
tasty.Add("Chicken Curry", true);
tasty.Add("Asparagus", false);
Console.WriteLine(tasty["Asparagus"]);

//Dictionary foreach
//KeyValuePair must match Dictionary datatypes
foreach (KeyValuePair<string, bool> kvp in tasty)
{
    //kvp.Key returns key
    //kvp.Value returns value
    if(kvp.Value == true)
    {
        Console.WriteLine($"{kvp.Key} is tasty");
    }
    else
    {
        Console.WriteLine($"{kvp.Key} is icky!");
    }
}

Dictionary<string, int> Phonebook = new Dictionary<string, int>();
Phonebook.Add("Yumi's Pizza", 1234567890);
Phonebook.Add("Young Chad's Deli", 1112223333);
Phonebook.Add("Paco's Tacos", 1000000001);
string foodChoice = "Yumi's Pizza";
Console.WriteLine(Phonebook[foodChoice]);
Console.WriteLine("Phonebook:");
foreach(KeyValuePair<string, int> kvp in Phonebook)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

//Exercise 47
List<string> prompt = new List<string>();
bool runExercise = true;
while(runExercise == true)
{
    Console.WriteLine("Enter some text");
    prompt.Add(Console.ReadLine());

    foreach (string s in prompt)
    {
        Console.Write(s + " ");
    }
    Console.WriteLine();

    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            runExercise = false;
            break;
        }
    }
    
}
//exercise 48
List<int> NumbersToAdd = new List<int>();
bool addNumbers = true;
while (addNumbers)
{
    Console.WriteLine("Enter a number. q to quit");
    string numChoice = Console.ReadLine();
    if(numChoice == "q")
    {
        break;//Stop adding nums
    }
    else
    {
        NumbersToAdd.Add(int.Parse(numChoice));
    }
}
string result = string.Join("+", NumbersToAdd);
Console.WriteLine($"{result} = {NumbersToAdd.Sum()}");

//---------------------------------------------------------------------------
//Non-Generic
//DO NOT USE IN MODERN CODE. OUTDATED. JUSTIN WILL FIGHT YOU (ง'̀-'́)ง


//Array List
ArrayList numbers = new ArrayList();
numbers.Add(5);
//Nongenerics allow any data
//numbers.Add("Michigan");
foreach(int i in numbers)
{
    Console.WriteLine(i);
}

//Hashtable
Hashtable ht = new Hashtable();
ht.Add("001", "John");
ht.Add("002", "Paul");
Console.WriteLine(ht["001"]);
//Nongenerics allow any data
//ht.Add(3, "Steve");
//Console.WriteLine(ht["003"]);