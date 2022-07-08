using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    internal class Dog : iAnimal
    {
        public string NickName { get; set; }
        public double Weight { get; set ; }
        public double Height { get; set; }

        public Dog(string _nickName, double _weight, double _height)
        {
            NickName = _nickName;
            Weight = _weight;
            Height = _height;
        }
        public string GetDescription()
        {
            return $"{NickName} is the goodest of all the dogs. This dog weighs {Weight} pounds and is {Height} feet tall";
        }

        public string Interact()
        {
            return $"{NickName} walks up to you and lays on your lap. You are trapped there for 4 hours";
        }
    }
}
