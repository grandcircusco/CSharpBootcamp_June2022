using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritence
{
    internal class Tiger : Animal
    {
        //properties
        public double StripeCount { get; set; }
        public double ClawLength { get; set; }
        //constuctor
        public Tiger(string _nickName, double _height, double _weight, double _stripeCount, double _clawLength) : base(_nickName, _height, _weight)
        {
            StripeCount = _stripeCount;
            ClawLength = _clawLength;
        }
        //methods
        public override string GetDescription()
        {
            return $"{NickName} is a {Height} feet tall tiger that weighs {Weight} pounds, has {StripeCount} stripes and {ClawLength} inch long claws.";
        }
        public override string Interact()
        {
            return $"You rode {NickName}, the majestic tiger, through the savannah.";
        }
    }
}
