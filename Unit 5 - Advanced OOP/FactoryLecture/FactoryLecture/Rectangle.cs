using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class Rectangle : iShape
    {
        public void draw()
        {
            Console.WriteLine("You draw even lengths and widths");
        }
    }
}
