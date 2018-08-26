using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Llama : Animal
    {
        public Llama(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }

        public sealed override string Sound()
        {
            return base.Sound() + " hhhmmmmmm";
        }
    }

    class AlpacaLlama : Llama
    {
        public AlpacaLlama(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

    class GuanacoLlama : Llama
    {
        public GuanacoLlama(string _name, int _age, string _gender) : base(_name, _age, _gender)
        {
        }
    }

}
