namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Peter = new Person("Peter", 20);
            Person George = new Person("George", 18);
            Person Jose = new Person("Jose", 43);

            Console.WriteLine($"{Peter.Name} {Peter.Age}");
            Console.WriteLine($"{George.Name} {George.Age}");
            Console.WriteLine($"{George.Name} {George.Age}");
        }
    }
}
