

Console.WriteLine("Please enter a string you want to reverse");
string word = Console.ReadLine();
string sentence = "";
//Reversing whole sentence while keeping words in same spot
foreach(string x in word.Split(" "))
{
    //if current word contains number or symbol, just add to sentence
    if(x.Any(l => Char.IsDigit(l) || Char.IsSymbol(l)))
    {
        Console.WriteLine("Word with symbol or number found. Added to sentence without modification");
        sentence += x + " ";
    }
    else
    {
        sentence += reverse(x) + " ";
    }
}

Console.WriteLine(sentence);

//methods
static string reverse(string value)
{
    Stack<char> letters = new Stack<char>();
    //for later comments, assume user entered "what"
    //Stack currently empty
    foreach (char l in value)
    {
        //Take letter and add it to top of stack
        letters.Push(l);
    }

    //Stack: w, h, a, t
    //Right of stack is top, left is bottom

    //As we pull values out of stack, add to the string
    //grabs values from stack from top (right) to bottom (left)
    string result = "";
    foreach (char l in value)
    {
        result += letters.Pop();
    }
    //result == "tahw"
    return result;
}