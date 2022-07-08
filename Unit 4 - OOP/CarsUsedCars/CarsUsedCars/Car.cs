using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsUsedCars
{
    internal class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        //No arguement
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }

        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }
        //Methods
        public override string ToString()
        {
            return String.Format("{0,-15} {1,-15} {2,-4} ${3,-10}", Make, Model, Year, Price);
        }
    }
}
