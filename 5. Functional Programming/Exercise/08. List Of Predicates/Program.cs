namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= upperLimit ; i++)
            {
                numbers.Add(i);
            }

            Func<int[], int, bool> predicate = (arr, i) =>
            {
                bool isDivisable = true;

                foreach (int n in divisors)
                {
                    if (i % n != 0)
                    {
                        return false;
                    }
                }
                return isDivisable;
            };

            var result = numbers.Where(number => predicate(divisors, number));

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
