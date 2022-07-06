using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Dragon : Animal
    {
        public bool HasWings { get; set; }
        public int BreathTemp { get; set; }
        public Dragon(string _nickName, double _height, double _weight, bool _hasWings, int _breathTemp) : base(_nickName, _height, _weight)
        {
            HasWings = _hasWings;
            BreathTemp = _breathTemp;
        }
        public override string GetDescription()
        {
            string message = $"{NickName} is {Height} feet tall and weighs {Weight} pounds.";
            message += (HasWings) ? " It can fly" : " It cannot fly";
            message += $" and its breath can reach up to {BreathTemp}F.";
            return message;
        }
        public override string Interact()
        {
            if (BreathTemp > 1500)
            {
                return $"You put on some oven mitts and pet {NickName}";
            }
            if (HasWings)
            {
                return $"{NickName} gives you a ride through the sky";
            }
            else
            {
                return $"{NickName} carries you through the dungeon";
            }
        }
    }
}
