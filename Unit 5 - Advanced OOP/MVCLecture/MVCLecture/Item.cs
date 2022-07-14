using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class Item
    {
        //properties
        public string Name { get; set; }
        public double Price { get; set; }
        //Constructor
        public Item(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
    }
}
