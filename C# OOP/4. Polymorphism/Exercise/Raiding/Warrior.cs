using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            Name = name;
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"Warrior - {Name} hit for {Power} damage";
        }
    }
}
