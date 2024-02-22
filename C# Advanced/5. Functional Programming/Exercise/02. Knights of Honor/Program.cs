namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> print = s => Console.WriteLine($"Sir {s}");

            Array.ForEach(input, print);
        }
    }
}
