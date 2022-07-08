using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLecture
{
    internal interface iAnimal
    {
        public string NickName { get; set; }
        public double Weight{ get; set; }
        public double Height { get; set; }
        public string GetDescription();
        public string Interact();
    }
}
