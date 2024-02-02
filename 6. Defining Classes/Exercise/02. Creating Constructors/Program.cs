namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(15);
            var person3 = new Person("Petar", 18);

            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");
            Console.WriteLine($"{person3.Name} {person3.Age}");
        }
    }
}
