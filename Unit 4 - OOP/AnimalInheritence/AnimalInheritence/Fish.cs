using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Fish :Animal
    {
        //Properties
        public string Color { get; set; }
        public bool HasSpikes { get; set; }
        //Constructor
        public Fish(string _nickname, double _height, double _weight, string _color, bool _hasSpikes) : base(_nickname, _height, _weight)
        {
            Color = _color;
            HasSpikes = _hasSpikes;
        }
        public override string GetDescription()
        {
            if (HasSpikes)
            {
                return $"{NickName} is {Height} feet long and weighs {Weight} pounds. {NickName} is {Color} and has spikes";
            }
            else
            {
                return $"{NickName} is {Height} feet long and weighs {Weight} pounds. {NickName} is {Color} and doesn't have spikes";
            }
        }
        public override string Interact()
        {
            if (HasSpikes)
            {
                return $"You touched the {NickName}. You got poked by it's spikes";
            }
            else
            {
                return $"You touched the {NickName}. It's a little slimy, but super smooth";
            }
        }
    }
}
