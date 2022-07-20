using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country> 
        {
            new Country("United States", "North America", new List<string> {"Red", "White", "Blue"}),
            new Country("Sweden", "Europe", new List<string> { "Yellow", "Blue" }),
            new Country("Brazil", "South America", new List<string>{"Blue", "Green", "Yellow"}),
            new Country("Germany", "Europe", new List<string>{"Red", "Black", "Yellow"}),
            new Country("North Korea ","Asia", new List<string> { "Red", "White" }),
            new Country("South Korea","Asia",new List<string>{"Red","White","Blue","Black"}),
            new Country("Canada", "North America", new List<string>{"Red", "White"}),
            new Country("South Africa", "Africa", new List<string> {"Green", "Yellow", "White", "Red", "Blue", "Black"}),
            new Country("Japan","Asia", new List<string>{"Red","White"}),
            new Country("Zimbabwe", "Africa", new List<string> {"Green", "Yellow", "Red", "White", "Black"}),
            new Country("Russia", "Asia", new List<string>{"Blue", "Red", "White"}),
        };
        //Constructor
        public CountryController()
        {
            //empty
        }

        //methods
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            CountryListView listView = new CountryListView(CountryDb);
            Console.WriteLine("Hello! Welcome to the Country app. Please select a country from the following list.");
            bool runProgram = true;
            while (runProgram)
            {
                listView.Display();
                //get user choice
                int index = 0;
                while (true)
                {
                    //Make sure its a number
                    while (!int.TryParse(Console.ReadLine(), out index))
                    {
                        Console.WriteLine("Not a valid input. Try again.");
                    }
                    //Make sure its in range
                    if (index >= 0 && index < CountryDb.Count)
                    {
                        //valid input
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not in range");
                    }
                }
                CountryAction(CountryDb[index]);

                Console.WriteLine("Would you like to learn about another Country? y/n");
                while (true)
                {
                    string choice = Console.ReadLine().ToLower().Trim();
                    if(choice == "y")
                    {
                        runProgram = true;
                        break;
                    }
                    else if(choice == "n")
                    {
                        runProgram=false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input. Try again.");
                    }
                }
            }
            
        }
    }
}
