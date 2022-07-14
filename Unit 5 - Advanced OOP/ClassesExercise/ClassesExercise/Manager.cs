using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Manager : Employee
    {
        public Manager(string _name, double _salary) : base(_name, _salary)
        {
            //No new parameters, so no assigning
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} lays back and watches tv. They made {Salary} and are considering their 3rd yacht");
        }
    }
}
