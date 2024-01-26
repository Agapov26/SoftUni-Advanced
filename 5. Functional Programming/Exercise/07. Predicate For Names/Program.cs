namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> predicate = s => s.Length <= length;

            var result = names.Where(name => predicate(name));

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
