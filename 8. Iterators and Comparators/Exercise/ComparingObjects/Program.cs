namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END") 
            {
                string[] properties = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new()
                {
                    Name  = properties[0],
                    Age = int.Parse(properties[1]),
                    Town = properties[2],
                };

                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            Person refference = people[index];

            int equal = 0;
            int different = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(refference) == 0)
                {
                    equal++;
                }

                else
                {
                    different++;
                }
            }

            if (equal == 1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine($"{equal} {different} {people.Count}");
            }
        }
    }
}
