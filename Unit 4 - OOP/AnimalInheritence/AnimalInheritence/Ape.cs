using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Ape : Animal
    {
        public string Orgin { get; set; }
        public int Age { get; set; }
        public Ape(string _nickname, double _height, double _weight, string _orgin, int _age) : base(_nickname, _height, _weight)
        {
            Orgin = _orgin;
            Age = _age;
        }
        //methods
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds. Their age is {Age}, and their orgin is {Orgin}";
        }
        public override string Interact()
        {
            return $"{NickName} will throw poop at you.";
        }
    }
}
