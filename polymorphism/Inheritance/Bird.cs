using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }

        public string WingSpan { get; set; }
        public sealed override string Sound()
        {
            return base.Sound() + " tweet tweet";
        }
    }

    class DuckBird : Bird
    {
        public DuckBird(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class BantamChickenBird : Bird
    {
        public BantamChickenBird(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class PeacockBird : Bird
    {
        public PeacockBird(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }
}
