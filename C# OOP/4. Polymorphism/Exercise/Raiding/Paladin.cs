using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        {
            Name = name;
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}
