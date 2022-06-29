bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter a word");
    string word = Console.ReadLine();
    int vowelIndex = word.ToLower().IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
    //Console.WriteLine(vowelIndex);
    if (vowelIndex == 0)
    {
        word += "way";
    }
    else if(vowelIndex == -1)
    {
        word += "ay";
    }
    else
    {
        word = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
    }
    Console.WriteLine(word);

    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if (choice.ToLower().Trim() == "y")
        {
            break;
        }
        else if (choice.ToLower().Trim() == "n")
        {
            runProgram = false;
            break;
        }
    }
}
