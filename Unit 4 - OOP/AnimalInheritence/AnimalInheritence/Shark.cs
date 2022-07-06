using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Shark : Animal
    {
        public string Species { get; set; }
        public string WaterType { get; set; }
        public string HasTeeth { get; set; }
        public Shark(string _nickName, double _height, double _weight, string _species, string _waterType, string _hasTeeth) : base(_nickName, _height, _weight)
        {
            Species = _species;
            WaterType = _waterType;
            HasTeeth = _hasTeeth;
        }
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet long and weights {Weight} pounds. {Species} sharks live in {WaterType} and {HasTeeth} ";
        }
        public override string Interact()
        {
            return $"The {NickName} swims by. It ignores you for now...";
        }
    }
}
