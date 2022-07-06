using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Ailuropoda_melanoleuca : Animal
    {
        //property
        public double CuteLevel { get; set; }
        public string Color { get; set; }
        //constructor
        public Ailuropoda_melanoleuca(string _nickname, double _height, double _weight, double _cuteLevel, string _color) : base( _nickname,  _height,  _weight)
        {
            CuteLevel = _cuteLevel;
            Color = _color;
        }
        //methods
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feel tall and weighs {Weight} pounds. They have two colors: {Color} and its cuteness level is {CuteLevel}!!";
        }
        public override string Interact()
        {
            return $"You intereacted with {NickName} its looks hungry. I wouldn't go to close.";
        }
    }
}
