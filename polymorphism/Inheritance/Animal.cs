using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string Name { get; set; }
        public int AnimalID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual string Sound()
        {
            return $"The animal makes the sound:";
        }

        public Animal (string _name, int _age, string _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
    }
}
