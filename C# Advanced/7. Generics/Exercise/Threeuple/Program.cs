namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numberTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string,string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2], nameTokens[3]);
            Threeuple<string, int, bool> beers = new(beerTokens[0], int.Parse(beerTokens[1]) , beerTokens[2] == "drunk");
            Threeuple<string, double, string> number = new(numberTokens[0], double.Parse(numberTokens[1]), numberTokens[2]);

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(number);
        }
    }
}
