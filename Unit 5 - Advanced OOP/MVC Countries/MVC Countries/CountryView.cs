using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {
        //Properties
        public Country DisplayCountry { get; set; }
        //Constructor
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        //Methods
        public void Display()
        {
            Console.WriteLine($"Name:{DisplayCountry.Name}");
            Console.WriteLine($"Continent:{ DisplayCountry.Continent}");
            Console.WriteLine("Colors:");
            //Looping through colors List
            foreach(string c in DisplayCountry.Colors)
            {
                //if(c == "Red")
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //}
                //else if(c == "White")
                //{
                //    Console.ForegroundColor= ConsoleColor.White;
                //}
                //else if(c == "Blue")
                //{
                //    Console.ForegroundColor = ConsoleColor.Blue;
                //}

                Console.ForegroundColor = Enum.Parse<ConsoleColor>(c);
                if(c == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(c);
                Console.ResetColor();
            }
        }
    }
}
