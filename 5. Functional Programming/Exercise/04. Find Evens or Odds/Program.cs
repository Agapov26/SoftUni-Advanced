namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string type = Console.ReadLine();

            int startNumber = number[0];
            int endNumber = number[1];

            List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = i => true;

            if (type == "even")
            {
                predicate = i => i % 2 == 0;
            }

            else if (type == "odd")
            {
                predicate = i => i % 2 != 0;
            }

            var filteredNumbers = numbers.Where(new Func<int, bool>(predicate));

            Console.WriteLine(string.Join(' ', filteredNumbers));
        }
    }
}
