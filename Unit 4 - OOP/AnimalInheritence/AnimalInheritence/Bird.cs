using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Bird : Animal
    {
        public string FeatherColor { get; set; }
        public double WingSpan { get; set; }
        //constructor
        public Bird(string _nickName, double _height, double _weight, string _featherColor, double _wingSpan) : base(_nickName, _height, _weight)
        {
            FeatherColor = _featherColor;
            WingSpan = _wingSpan;
        }
        //methods
        public override string Interact()
        {
            return $"You feed {NickName} some seeds.";
        }
        public override string GetDescription()
        {
            return $"{NickName} is a bird with {FeatherColor} colored feathers. \nIt is {Height} feet tall, weighs {Weight} pounds, and has a wingspan of {WingSpan} feet.";
        }
    }
}
