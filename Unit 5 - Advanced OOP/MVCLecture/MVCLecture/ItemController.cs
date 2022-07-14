using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLecture
{
    internal class ItemController
    {
        //properties
        //pretend its a DB of store items
        public List<Item> items = new List<Item>()
        {
            new Item("Baja Blast", 2),
            new Item("Fortnite Battle Pass", 19),
            new Item("Tacos", 3),
            new Item("Faygo Cola", 1),
        };

        //constructor
        public ItemController()
        {

        }

        //Methods
        public void DisplayItems()
        {
            foreach(Item i in items)
            {
                ItemView view = new ItemView(i);
                view.Display();
            }
        }

    }
}
