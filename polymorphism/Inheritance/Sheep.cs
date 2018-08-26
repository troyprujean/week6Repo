using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Sheep : Animal
    {
        public Sheep(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }

        public sealed override string Sound()
        {
            return base.Sound() + " baaah baaah";
        }
    }

    class MerinoSheep : Sheep
    {
        public MerinoSheep(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class DorsetHornSheep : Sheep
    {
        public DorsetHornSheep(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }
}
