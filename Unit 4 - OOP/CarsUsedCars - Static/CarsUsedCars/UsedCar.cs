using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsUsedCars
{
    internal class UsedCar : Car
    {
        public double Mileage { get; set; }
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage): base(_make, _model, _year, _price)
        {
            Mileage = _mileage;
        }
        //methods
        public override string ToString()
        {
            return base.ToString() + String.Format(" USED {0,-10} miles", Mileage);
        }
    }
}
