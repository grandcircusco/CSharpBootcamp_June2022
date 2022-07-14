using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Worker : Employee
    {
        public Worker(string _name, double _salary) : base(_name, _salary)
        {
            //no new params that need to be assigned
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is overworked and makes {Salary} dollars. They are considering leaving");
        }
    }
}
