// Given a stirng, move the first letter the end of the word using substring

string word = "Weather";

Console.WriteLine(MoveFirstLetter(word));





// IF a word begins with J or C, change the word to Apple

string w1 = "Create";
string w2 = "Water";

ConvertWord(ref w1);
ConvertWord(ref w2);
Console.WriteLine(w1);
Console.WriteLine(w2);


static void ConvertWord( ref string word)
{
    char[] wordBank = new char[] { 'J', 'C' };
    foreach(char letter in wordBank)
    {
        if(word.StartsWith(letter) == true)
        {
            word = "Apple";
        }
    }

}


static string MoveFirstLetter(string word)
{
    string modified;
    modified = word.Substring(1, word.Length - 1) + word.Substring(0, 1);
    return modified;
}

