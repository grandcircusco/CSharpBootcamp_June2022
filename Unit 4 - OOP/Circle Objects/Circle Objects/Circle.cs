using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        //field
        public double radius;
        
        //private double radius;
        //property
        //public double Radius { 
        //    get 
        //    {
        //        return radius;
        //    } 
        //    set 
        //    { 
        //        radius = value + 100; 
        //    } 
        //}


        //constructor
        public Circle(double _radius)
        {
            radius = _radius;
        }
        //Methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }
}
