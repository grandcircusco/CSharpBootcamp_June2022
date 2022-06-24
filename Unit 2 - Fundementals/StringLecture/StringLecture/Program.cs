//intitalizing a string
string name = "Justin";
//String name2 = "Justin";
char[] letters = { 'h', 'e', 'l', 'l', 'o' };
string hello = new string(letters);

//joining strings
string fullname = name + " Jones";
string fullname2 = string.Concat(name, " jones");

//string comparing
Console.WriteLine(fullname);
Console.WriteLine(fullname2);

if(fullname == fullname2)
{
    Console.WriteLine("== true");
}
else
{
    Console.WriteLine("== false");
}

//add true to turn on case ignoring
if(string.Compare(fullname, fullname2, true) == 0)
{
    Console.WriteLine("string.compare true");
}
else
{
    Console.WriteLine("string.compare false");
}

if (fullname.Equals(fullname2))
{
    Console.WriteLine(".equals true");
}
else
{
    Console.WriteLine(".equals false");
}
//string functions

//finds location of the inputted string
Console.WriteLine(fullname.IndexOf(" "));
//finds last location of the inputted string
Console.WriteLine(fullname.LastIndexOf("s"));
//returns a bool based on if string ends with input
Console.WriteLine(fullname.EndsWith("Jones"));
//creates a new string based on inputs
string modifiedFullname = fullname.Replace("s", "$");
Console.WriteLine(modifiedFullname);
//seperates string into individual chars
char[] splitname = fullname.ToCharArray();
foreach(char c in splitname)
{
    Console.WriteLine(c);
}
//splits words into an array based on the inputted string
string[] names = fullname.Split(" ");
//combined shows how to re-combine them
string combined = "";
foreach(string n in names)
{
    Console.WriteLine(n);
    combined += n + " ";
}
Console.WriteLine(combined);
//substring returns new string based on (start index) or (start index, length)
Console.WriteLine(fullname.Substring(1));
Console.WriteLine(fullname.Substring(fullname.Length - 1));
Console.WriteLine(fullname.Substring(0,1));
//returns lowercase or uppercase version of string
Console.WriteLine(fullname.ToLower());
Console.WriteLine(fullname.ToUpper());

//pretend user entered Yes
string choice = "    YeS   ";
//trim removes all empty spaces at start and end of string
Console.WriteLine(choice.Trim());
//lower and trim combined
if(choice.ToLower().Trim() == "yes")
{
    Console.WriteLine("good choice");
}


// Given a string put the first letter to the end

// if a word starts with a J or B, change the word to Josh