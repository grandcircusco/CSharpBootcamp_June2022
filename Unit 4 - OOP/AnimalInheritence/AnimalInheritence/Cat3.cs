using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Cat3 : Animal
    {
        //properties 
        public bool Friendly { get; set; }
        public string Habitat { get; set; }

        //made constructor
        public Cat3(string _nickname, double _height, double _weight, bool _friendly, string _habitat) :
            base(_nickname, _height, _weight)
        {
            Friendly = _friendly;
            Habitat = _habitat;
        }

        // methods

        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds. Study shows {Friendly}, when reviewing friendliness, and their preferred habitat is {Habitat}";
        }

        public override string Interact()
        {
            return $"{NickName} decided to cooperate with you today, but don't touch their babies";

        }
    }
}
