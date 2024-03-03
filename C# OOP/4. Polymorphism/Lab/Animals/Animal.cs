using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.favouriteFood = favouriteFood;
        }

        public string Name { get; protected set; }
        public string favouriteFood { get; protected set; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {favouriteFood}";
        }
    }
}
