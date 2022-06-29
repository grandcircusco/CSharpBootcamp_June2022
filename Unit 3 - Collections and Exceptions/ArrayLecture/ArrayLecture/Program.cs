//Creating arrays
//new int[5] makes the array 5 big
int[] favNumbers = new int[5];
//new array with starting values
int[] favNumbers2 = { 0, 10, 9, 69, 420, 3 };
//new array made by a method
string sentence = "I am a teacher!";
string[] words = sentence.Split(' ');
//new array with size chosen by variable
int librarySize = 100;
string[] books = new string[librarySize];

//Accessing Values
int result = favNumbers2[4];
Console.WriteLine(result);
//use variable as index
int index = 2;
Console.WriteLine(favNumbers2[index]);
//throw an error
//IndexOutOfRangeException means you are getting an element that is past the max index
//Console.WriteLine(favNumbers2[6]);

//Assigning/Reassigning array
string[] friends = new string[3];
friends[0] = "Josh";
friends[1] = "Tommy";
friends[2] = "Billy";
//cannot access outside of range
//friends[3] = "Pikachu";
friends[2] = "The pope";

//for loop
//commonly used if you need to know index or make changes
//use < not <= to keep in range
for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}

double[] prices = { 1.99, 2.50, 3, 0.50, 1 };
double total = 0;
for(int i = 0; i < prices.Length; i++)
{
    total += prices[i];
}
Console.WriteLine(total);

//foreach
//commonly used if you just need every value or want simple loop
string[] cars = { "Tesla", "Ford", "Cardboard Box", "Bike" };
foreach(string c in cars)
{
    //Cannot change value of the current element mid foreach loop
    //c += " 2022";
    Console.WriteLine(c);
}

//resusing prices array
double total2 = 0;
foreach(double p in prices)
{
    total2 += p;
}
double avg = total2 / prices.Length;
Console.WriteLine(avg);

//double avg2 = prices.Average();

//Array methods
Array.Clear(cars);
foreach (string c in cars)
{
    Console.WriteLine(c);
}
Array.Reverse(friends);
for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}
//built in methods
Console.WriteLine(prices.Average());
Console.WriteLine(prices.Sum());
Console.WriteLine(prices.Min());
Console.WriteLine(prices.Max());

//copying
//Old c# doesn't copy with this, it references memory
int[] FavoriteNums3 = favNumbers2;
//this is how you copy in old c#
int[] FavoriteNum4 = new int[favNumbers2.Length];
favNumbers2.CopyTo(FavoriteNum4,0);

//2d Arrays
int[,] ExcelSheet = new int[3,2];
Console.WriteLine(ExcelSheet[0,1]);

//Jagged Arrays
int[][] Jagged = new int[5][];
Jagged[0] = new int[5];
Jagged[1] = new int[10];
Jagged[2] = new int[3];
Console.WriteLine(Jagged[1][7]);