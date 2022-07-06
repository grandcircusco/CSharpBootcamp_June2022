using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Animal
    {
        public string NickName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        //constructor
        public Animal(string _nickname, double _height, double _weight)
        {
            NickName = _nickname;
            Height = _height;
            Weight = _weight;
        }
        //methods
        public virtual string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds";
        }

        public virtual string Interact()
        {
            return $"You interacted with {NickName}";
        }
    }
}
