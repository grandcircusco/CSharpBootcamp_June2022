using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsUsedCars
{
    internal class Car
    {
        public string Make { get; set; }
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

        //STATIC SECTION
        public static List<Car> Cars = new List<Car>()
        {
            new Car("Tesla", "Model S", 2022, 60000),
            new UsedCar("Cardboard Box", "Shipping", 2016, 15, 100),
            new Car("Jeep", "Wrangler", 2023, 79000),
            new UsedCar("Chevy", "Sonic", 2015, 15000, 68900),
            new UsedCar("Dodge", "Durango", 2018, 17800, 150000),
            new Car("Ford", "Bronco Sport", 2023, 68000),
            new UsedCar("Flintstones", "'ol reliable", 2, 500, 600000),
            new UsedCar("Nature's Finest", "Rock", 0, 0, 600000),
        };
        public static void ListCars()
        {
            Console.WriteLine("0. Add a car");
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Cars[i].ToString()}");
            }
        }

        public static void RemoveCars( int index)
        {
            Cars.RemoveAt(index);
        }
        public static void DisplayDetails(int index)
        {
            Console.WriteLine($"You have chosen a {Cars[index].Year} {Cars[index].Make} {Cars[index].Model}");
        }
    }
}
