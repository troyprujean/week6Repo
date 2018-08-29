using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class SpaceStation
    {
        public abstract string FireLaser();
        public abstract int HitPoints { get; set; }
        public abstract int Damage { get; set; }
        
    }
}
