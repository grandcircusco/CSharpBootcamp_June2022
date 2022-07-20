using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryListView
    {
        //property
        public List<Country> Countries { get; set; }
        //constructor
        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }
        //methods
        public void Display()
        {
            for(int i = 0; i< Countries.Count; i++)
            {
                Console.WriteLine($"{i} {Countries[i].Name}");
            }
        }
    }
}
