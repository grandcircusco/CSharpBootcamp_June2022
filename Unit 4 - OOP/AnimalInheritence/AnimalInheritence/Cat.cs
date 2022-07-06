using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Cat : Animal
    {
        public int FurLength { get; set; }
        public int CurrentAnger { get; set; }
        public Cat(string _nickname, double _height, double _weight, int _furLength, int _currentAnger) : base(_nickname, _height, _weight)
        {
            FurLength = _furLength;
            CurrentAnger = _currentAnger;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $" This cat has a fur length of {FurLength} inches and is currently {CurrentAnger}/10 angry!";
        }

        public override string Interact()
        {
            return $"You try to pet {NickName} but it bites you instead";
        }
    }
}
