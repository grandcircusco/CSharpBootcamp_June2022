using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Dolphin : Animal
    {
        public int WaterSpeed { get; set; }
        public int JumpHeight { get; set; }
        public Dolphin(string _nickname, double _height, double _weight, int _waterSpeed, int _jumpHeight) : base(_nickname, _height, _weight)
        {
            WaterSpeed = _waterSpeed;
            JumpHeight = _jumpHeight;
        }
        public override string GetDescription()
        {
            return $"{NickName} is {Height} feet tall and weighs {Weight} pounds. It has a water speed of {WaterSpeed}mph and can jump {JumpHeight} feet in the air";
        }
        public override string Interact()
        {
            return base.Interact() + $" by feeding it Mackeral. {NickName} is now pleased!";
        }
    }
}
