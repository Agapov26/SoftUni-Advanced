using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name) 
        {
            Name = name;
            Power = 80;
        }

        public override string CastAbility()
        {
            return $"Druid - {Name} healed for {Power}";
        }
    }
}
