string myGrade = "";
//when using out param, create the variable first.
bool passing = IsPassing(60, out myGrade);
Console.WriteLine($"With a 60, my grade is {myGrade}. Did i pass? {passing}");

//Out Parameter
//Out parameter allows for more than 1 return.
static bool IsPassing(int score, out string grade)
{
    if(score >= 90)
    {
        //grade gets passed back via out param
        grade = "A";
        return true;
    }
    else if(score >= 80)
    {
        grade="B";
        return true;
    }
    else if (score >= 70)
    {
        grade = "C";
        return true;
    }
    else if (score >= 60)
    {
        grade = "D";
        return true;
    }
    else
    {
        grade = "F";
        return false;
    }
}

//method short hand
//full version
static int multiplyByTwo(int x)
{
    return x * 2;
}
//short version
Func<int, int> MULTIPLYBYTWO = x => x * 2;

Console.WriteLine(multiplyByTwo(3));
Console.WriteLine(MULTIPLYBYTWO(6));
