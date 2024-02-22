namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            foreach (char c in input)
            {
                if (counter.ContainsKey(c))
                {
                    counter[c]++;
                }

                else
                {
                    counter.Add(c, 1);
                }
            }

            foreach (char c in counter.Keys)
            {
                Console.WriteLine($"{c}: {counter[c]} time/s");
            }
        }
    }
}
