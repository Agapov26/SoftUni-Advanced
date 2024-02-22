namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<int, bool> numbers = new Dictionary<int, bool>();

            for (int i = 0; i < lines; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(currentNum))
                {
                    numbers[currentNum] = !numbers[currentNum];
                }

                else
                {
                    numbers.Add(currentNum, false);
                }
            }

            foreach (int num in numbers.Keys)
            {
                if (numbers[num])
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
