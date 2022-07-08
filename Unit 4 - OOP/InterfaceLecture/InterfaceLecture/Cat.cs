using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    internal class Cat : iAnimal
    {
        public string NickName { get; set; }
        public double Weight { get; set ; }
        public double Height { get; set;  }

        public Cat(string _nickName, double _weight, double _height)
        {
            NickName = _nickName;
            Weight = _weight;
            Height = _height;
        }

        public string GetDescription()
        {
            return $"{NickName} the cat weighs {Weight} and is {Height} feet tall";
        }

        public string Interact()
        {
            return $"{NickName} goes to bite you";
        }
    }
}
