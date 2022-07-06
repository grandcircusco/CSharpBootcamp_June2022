using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Cat2 : Animal
    {
        public bool Thumbs { get; set; }
        public string Breed { get; set; }

        public Cat2(string _nickname, double _height, double _weight, bool _thumbs, string _breed) : base(_nickname, _height, _weight)
        {
            Thumbs = _thumbs;
            Breed = _breed;
        }

        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and {Weight} pounds. {NickName}'s breed is {Breed} and it is {Thumbs} that {NickName} is a thumb cat.";
        }

        public override string Interact()
        {
            if (Thumbs == true)
            {
                return $"You reach out to {NickName}. They reach back with their little thumb paws.";
            }
            else
            {
                return $"You reach out to {NickName}. They are unamused.";
            }
        }
    }
}
