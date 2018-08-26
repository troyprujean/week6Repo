using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Pig : Animal
    {
        public Pig(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }

        public sealed override string Sound()
        {
            return base.Sound() + " oink oink";
        }
    }

    class DomesticPig : Pig
    {
        public DomesticPig(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class WildPig : Pig
    {
        public WildPig(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }
}
