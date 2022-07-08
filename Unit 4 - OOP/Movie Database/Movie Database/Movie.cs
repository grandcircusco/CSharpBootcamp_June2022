using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    internal class Movie
    {
        //Properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int RunTime { get; set; }

        //Constructor
        public Movie(string _title, string _category, int _year, int _runTime)
        {
            Title = _title;
            Category = _category;
            Year = _year;
            RunTime = _runTime;
        }
    }
}
