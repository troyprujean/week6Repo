using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cow : Animal
    {
        public Cow(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }

        public sealed override string Sound()
        {
            return base.Sound() + " moooooo";
        }
    }

    class FresianCow : Cow
    {
        public FresianCow(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class AngusCow : Cow
    {
        public AngusCow(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class TexasLonghornCow : Cow
    {
        public TexasLonghornCow(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }
}
