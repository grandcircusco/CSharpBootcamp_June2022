using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Hippo : Animal
    {
        public double JawSize;
        public int Age;
        public Hippo(string _nickName, double _height, double _weight, double _jawSize, int _age) : base(_nickName, _height, _weight)
        {
            JawSize = _jawSize;
            Age = _age;
        }
        //methods
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds.  Their jaw is {JawSize} inches big, and they're only {Age} years old!";
        }
        public override string Interact()
        {
            return $"{NickName} gives you a ride down the river.";
        }
    }
}
