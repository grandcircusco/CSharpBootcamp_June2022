using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOPLecture
{
    internal class Pen
    {
        //properties
        public string Color;
        public string Brand;
        public string InkType;
        public decimal Price;
        public float Length;
        //private property - Don't want user to modify/access
        private int InkCount;

        //Constructor
        public Pen(string _color, string _brand, string _inkType, decimal _price, float _length)
        {
            Color = _color;
            Brand = _brand;
            InkType = _inkType;
            Price = _price;
            Length = _length;
            InkCount = 5; //This value is private. This doesn't get sent through parameters
        }

        //methods
        public string Draw()
        {
            if(InkCount > 0)
            {
                InkCount--;
                return $"The {Color} {Brand} drew a butterfly using {InkType}";
            }
            else
            {
                return "Pen is empty";
            }
            
        }
        //overloaded method
        public string Draw(string drawing)
        {
            if (InkCount > 0)
            {
                InkCount--;
                return $"The {Color} {Brand} drew a {drawing} using {InkType}";
            }
            else
            {
                return "Pen is empty";
            }
        }

        //static
        public static void asdf()
        {
            Console.WriteLine("I am static");
        }
    }
}
