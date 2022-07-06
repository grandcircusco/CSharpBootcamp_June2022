using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Dog :Animal
    {
        public string dogBreed { get; set; }
        public string furColors { get; set; }
        public Dog(string _nickName, double _height, double _weight, string _dogBreed, string _furColors) : base(_nickName, _height, _weight)
        {
            _dogBreed = dogBreed;
            _furColors = furColors;
        }
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds.  {NickName} is a {dogBreed} with {furColors} fur.";
        }
        public override string Interact()
        {
            return $"You gave {NickName} a treat and they started barking as loud as possible.";
        }
    }
}
