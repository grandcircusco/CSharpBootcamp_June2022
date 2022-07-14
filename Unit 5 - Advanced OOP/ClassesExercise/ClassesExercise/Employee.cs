using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal abstract class Employee
    {
        //properties
        public string Name { get; set; }
        public double Salary { get; set; }
        //constructor
        public Employee(string _name, double _salary)
        {
            Name = _name;
            Salary = _salary;
        }
        //Methods
        public abstract void Work(); //abstract = no functionality here
    }
}
