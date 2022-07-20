// See https://aka.ms/new-console-template for more information
using MovieDatabaseEF.Models;

Console.WriteLine("Welcome to the GC Movie DB");
//PopulateDB(); Commented out to prevent it from running again
Console.WriteLine("Would you like to search by Title or Genre?");
string choice = Console.ReadLine().ToLower().Trim();

//Making empty list. Associated choice will fill list
List<Movie> resultList = new List<Movie>();

if(choice == "title")
{
    Console.WriteLine("Please enter a title.");
    string title = Console.ReadLine().ToLower().Trim();
    resultList = SearchByTitle(title);
}
else if (choice == "genre")
{
    Console.WriteLine("Please enter a genre.");
    string genre = Console.ReadLine().ToLower().Trim();
    resultList = SearchByGenre(genre);
}

//Displaying result 
foreach(Movie m in resultList)
{
    Console.WriteLine(m.ToString());
}


//METHODS
static List<Movie> SearchByGenre(string genre)
{
    List<Movie> results = new List<Movie>();

    //Open DB, pull out all matching movies, save to result
    using(MovieDBContext context = new MovieDBContext())
    {
        results = context.Movies.Where(m => m.Genre.ToLower() == genre.ToLower()).ToList();
    }

    return results;
}

static List<Movie> SearchByTitle(string title)
{
    List<Movie> results = new List<Movie>();

    //Open DB, pull out all matching movies, save to result
    using (MovieDBContext context = new MovieDBContext())
    {
        results = context.Movies.Where(m => m.Title.ToLower().Contains(title.ToLower())).ToList();
    }

    return results;
}

static void PopulateDB()//Run to fill database. Uncomment this in main to run
{
    using (MovieDBContext context = new MovieDBContext())
    {
        List<Movie> list = new List<Movie>()
        {
            new Movie()
            {
                Title = "Lion King",
                Genre = "Animated",
                Runtime = 87
            },
            new Movie()
            {
                Title = "Ghostbusters",
                Genre = "Comedy",
                Runtime = 105
            },
            new Movie()
            {
                Title = "Avatar",
                Genre = "Animated",
                Runtime = 240
            },
            new Movie()
            {
                Title = "Back to the Future",
                Genre = "SciFi",
                Runtime = 116
            },
            new Movie()
            {
                Title = "Fast Times at Ridgemont High",
                Genre = "Comedy",
                Runtime = 90
            },
            new Movie()
            {
                Title = "Shrek",
                Genre = "Comedy",
                Runtime = 90
            },
            new Movie()
            {
                Title = "The Fast and the Furious",
                Genre = "Action",
                Runtime = 147
            },
            new Movie()
            {
                Title = "2 Fast 2 Furious",
                Genre = "Action",
                Runtime = 140
            },
            new Movie()
            {
                Title = "StarWars",
                Genre = "Action",
                Runtime = 136
            },
            new Movie()
            {
                Title = "StarWars2",
                Genre = "Action",
                Runtime = 120
            },
            new Movie()
            {
                Title = "StarWars3",
                Genre = "Action",
                Runtime = 140
            }
        };

        //Start of a transaction
        context.Movies.AddRange(list); //AddRange takes in a collection and adds all to db
        context.SaveChanges();
        //end transaction
    }
}