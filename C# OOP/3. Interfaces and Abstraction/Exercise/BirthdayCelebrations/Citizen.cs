using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen : IBirthable
    {
        public Citizen(string name, int age, string birthdate)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; private set; }
    }
}
