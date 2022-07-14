using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class Circle : iShape
    {
        public void draw()
        {
            Console.WriteLine("You draw a circle with perfect roundness.");
        }
    }
}
