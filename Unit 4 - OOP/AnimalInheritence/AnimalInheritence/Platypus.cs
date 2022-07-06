using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Platypus:Animal
    {
        string Color { get; set; }
        int AngerLevel { get; set; }
        public Platypus(string _nickName, double _height, double _weight, string _color, int _angerLevel) : base(_nickName, _height, _weight)
        {
            Color = _color;
            AngerLevel = _angerLevel;
        }
        //methods
        public override string GetDescription()
        {
            string describe = $"{NickName} is a {Color} platypus that is {Height} feet tall and weighs {Weight} pounds.";
            return AngerLevel < 10 ? describe : describe + " It has a menacing look";
        }
        public override string Interact()
        {
            string interact = $"You pet {NickName}, it rattles it's beak.";
            return AngerLevel < 10 ? interact : interact + " You narrowly avoid it's venomous bite.";
        }
    }
}
