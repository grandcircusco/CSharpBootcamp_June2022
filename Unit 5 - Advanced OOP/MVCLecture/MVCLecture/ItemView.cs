using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemView
    {
        //property
        public Item DisplayItem { get; set; }
        //constructor
        public ItemView(Item _displayItem)
        {
            DisplayItem = _displayItem;
        }
        //method
        public void Display()
        {
            Console.WriteLine($"{DisplayItem.Name} is sold for {DisplayItem.Price}");
        }
    }
}
