using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class ShapeFactory
    {
        //factory method
        public iShape getShape(string shapeType)
        {
            if(shapeType == "Rectangle")
            {
                return new Rectangle();
            }
            else if(shapeType == "Circle")
            {
                return new Circle();
            }
            else if(shapeType == "Square")
            {
                return new Square();
            }
            else
            {
                return null;//Shape choice was not valid
            }
        }
    }
}
