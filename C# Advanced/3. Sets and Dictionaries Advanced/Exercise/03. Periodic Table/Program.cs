namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < lines; i++)
            {
                string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string element in elements)
                {
                    chemicalElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', chemicalElements));
        }
    }
}
