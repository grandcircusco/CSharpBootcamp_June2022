using System.Text.RegularExpressions;

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter a word");
    string sentence = Console.ReadLine();

    if(sentence == null || sentence == "")
    {
        Console.WriteLine("word was empty");
        continue;
    }

    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    char[] punctuation = { '.', ',', '!', '?' };
    char[] numberSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#','$', '%', '^', '&', '*', '(', ')'};
    bool startsVowel = false;

    //split sentence into multiple words
    string[] words = sentence.Split(' ');
    //string where we combine the sentence
    string result = "";
    foreach(string input in words)
    {
        //check for numbers
        bool containsNumber = false;
        foreach (char l in input)
        {
            foreach (char n in numberSymbols)
            {
                if (l == n && containsNumber == false)
                {
                    Console.WriteLine("Contains a number or a symbol");
                    containsNumber = true;
                }
            }
        }

        if (containsNumber == true)
        {
            //Console.WriteLine(input);
            result += input + " ";
        }
        else
        {
            //loops through each vowel to check
            foreach (char v in vowels)
            {
                if (input.ToLower()[0] == v)
                {
                    //found a vowel at start of word
                    startsVowel = true;
                }
            }
            string modified = input;

            //check if last character is punctuation
            string lastLetter = input.Substring(input.Length - 1);
            foreach (char p in punctuation)
            {
                //turn char p into a string for comparing
                if (p.ToString() == lastLetter)
                {
                    //if punctuation is found, remove it
                    modified = input.Substring(0, input.Length - 1);
                }
            }

            if (startsVowel == true)
            {
                //vowel logic
                modified = convertVowel(modified);
            }
            else
            {
                //consonant logic
                modified = convertConsonant(modified);
            }

            //add punctuation back on
            foreach (char p in punctuation)
            {
                //turn char p into a string for comparing
                if (p.ToString() == lastLetter)
                {
                    //adding punctuation back on
                    modified += lastLetter;
                }
            }

            result += modified + " ";
        }
    }

    //final sentence display
    Console.WriteLine(result);

    //get out of program
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if(choice.ToLower().Trim() == "y")
        {
            //get us out of this loop, but keep program running
            break;
        }
        else if(choice.ToLower().Trim() == "n")
        {
            //get us out of this loop and stop the main loop
            runProgram = false;
            break;
        }
    }
}



//METHODS
//vowel
static string convertVowel(string x)
{
    return x + "way";
}

//consonant
static string convertConsonant(string x)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    for(int i = 0; i < x.Length; i++)
    {
        foreach(char v in vowels)
        {
            if(x[i] == v)
            {
                return x.Substring(i) + x.Substring(0, i) + "ay";
            }
        }
    }
    //words without vowels
    return x + "ay";
}