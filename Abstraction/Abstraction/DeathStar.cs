using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class DeathStar : SpaceStation
    {
        public override int HitPoints { get; set; }
        
        public override int Damage { get; set;  }

        public override string FireLaser()
        {
            return "Pew pew\n";
        }

        public DeathStar (int hitpoints, int damage)
        {
            HitPoints = hitpoints;
            Damage = damage;
        }
    }
}
