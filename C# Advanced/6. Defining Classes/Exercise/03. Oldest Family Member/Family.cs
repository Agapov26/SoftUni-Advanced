using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();
        public void AddMember(Person person)
        {
            people.Add(person);
        }

        public Person GetOldestMember()
        {
            int oldest = people.Max(p => p.Age);
            Person oldestPerson = people.FirstOrDefault(p => p.Age == oldest);
            return oldestPerson;
        }
    }
}
