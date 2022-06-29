//Lamdba Expressions
List<int> numbers = new List<int>
{
    5,4,1,3,9,8,6,7,2,0
};
//lamdba
//unicorn => unicorn % 2 == 1
int oddNumbers = numbers.Count(unicorn => unicorn % 2 == 1);

Console.WriteLine(oddNumbers);

//Query Expression Syntax
List<int> FiveOrGreater = (from n in numbers
                      where n >= 5
                      select n).ToList();
foreach(int n in FiveOrGreater)
{
    Console.WriteLine(n);
}

//Method Syntax
List<int> FiveOrGreater2 = numbers.Where(n => n >= 5).ToList();
foreach(int n in FiveOrGreater2)
{
    Console.WriteLine(n);
}

//Methods

//Where
//Its a filter. Returns collection based on condition
List<int> Ages = new List<int>() { 1, 19, 15, 21, 45, 50 };
List<int> LegalAges = Ages.Where(n => n >= 21).ToList();

//Foreach
//Quickly create a foreach on a loop
LegalAges.ForEach(a => Console.WriteLine(a));

//First (There is a Last as well)
//Return the first matching element
int Child = Ages.First(a => a < 5);
Console.WriteLine(Child);

//Any
//Returns a true if at least 1 element matches condition
bool isOverFiftyCheck = Ages.Any(a => a >= 50);
Console.WriteLine(isOverFiftyCheck);

//Average
double avgAge = Ages.Where(a => a >= 21).Average();
Console.WriteLine(avgAge);

//Sum
double sumAge = Ages.Where(a => a < 21).Sum();
Console.WriteLine(sumAge);