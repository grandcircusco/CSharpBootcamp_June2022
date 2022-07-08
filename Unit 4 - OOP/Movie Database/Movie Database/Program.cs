using Movie_Database;

List<Movie> movies = new List<Movie>()
{
    new Movie("Jurassic Park", "Scifi", 1993, 127),
    new Movie("Basket Case", "Horror", 1982, 91),
    new Movie("The Matrix","Scifi", 1999,136),
    new Movie("The Godfather", "Crime", 1972, 175),
    new Movie("The Faculty", "Horror",1998, 104),
    new Movie("Friday The 13th", "Horror",1980,95),
    new Movie("Minions: The Rise of Gru","Comedy",2022, 90),
    new Movie("Forrest Gump", "Drama", 1994,142),
    new Movie("Shallow Hal", "Comedy", 2001, 114),
    new Movie("Shrek", "Animated", 2001, 90),
    new Movie("A Silent Voice", "Anime",2016,129)
};

List<Movie> DistinctCategories = movies.GroupBy(m => m.Category).Select(m => m.First()).ToList();


bool runProgram = true;

//Short version
while (runProgram)
{
    Console.WriteLine("Please enter a movie category.");
    for(int i = 0; i < DistinctCategories.Count; i++)
    {
        Console.WriteLine($"{i}. {DistinctCategories[i].Category}");
    }
    int catId = 0;
    while (true)
    {
        catId = Validator.Validator.GetUserNumberInt();
        if(Validator.Validator.InRange(catId,0, DistinctCategories.Count - 1))
        {
            break;
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
    string category = DistinctCategories[catId].Category;
    movies.Where(m => m.Category == category).OrderBy(m => m.Title).ToList().ForEach(m =>
         Console.WriteLine($"Title:{m.Title} Category:{m.Category} Year:{m.Year} Runtime:{m.RunTime}")
    );
    runProgram = Validator.Validator.GetContinue();
}

//long version
//while (runProgram)
//{
//    Console.WriteLine("Please enter a movie category.");
//    //Manually writing categories
//    Console.WriteLine("1.Scifi");
//    Console.WriteLine("2.Horror");
//    Console.WriteLine("3.Crime");
//    Console.WriteLine("4.Comedy");
//    Console.WriteLine("5.Drama");
//    Console.WriteLine("6.Animated");
//    string category = "";
//    int catId = 0;
//    //Parse user choice until they give a number
//    while (true)
//    {
//        while (!int.TryParse(Console.ReadLine(), out catId))
//        {
//            Console.WriteLine("Please enter a number");
//        }
//        if(catId == 1)
//        {
//            category = "Scifi";
//            break;
//        }
//        else if (catId == 2)
//        {
//            category = "Horror";
//            break;
//        }
//        else if (catId == 3)
//        {
//            category = "Crime";
//            break;
//        }
//        else if (catId == 4)
//        {
//            category = "Comedy";
//            break;
//        }
//        else if (catId == 5)
//        {
//            category = "Drama";
//            break;
//        }
//        else if (catId == 6)
//        {
//            category = "Animated";
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Not a category number.");
//        }
//    }



//    //filter only matching categorys
//    List<Movie> result = new List<Movie>(); //start empty

//    foreach (Movie m in movies)
//    {
//        if (m.Category == category)
//        {
//            result.Add(m);//Adds matching movie in
//        }
//    }
//    //fully filled list
//    foreach (Movie m in result.OrderBy(m => m.Title))
//    {
//        Console.WriteLine($"Title:{m.Title} Category:{m.Category} Year:{m.Year} Runtime:{m.RunTime}");
//    }

//    //Ask if continue
//    while (true)
//    {
//        Console.WriteLine("Would you like to continue? y/n");
//        string choice = Console.ReadLine().ToLower().Trim();
//        if (choice == "y")
//        {
//            break;
//        }
//        else if (choice == "n")
//        {
//            runProgram = false;
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Not valid");
//        }
//    }
//}
