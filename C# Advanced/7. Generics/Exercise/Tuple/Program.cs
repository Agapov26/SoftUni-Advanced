﻿namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numberTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string> names = new($"{nameTokens[0]} {nameTokens[1]}", nameTokens[2]);
            CustomTuple<string, int> beers = new(beerTokens[0], int.Parse(beerTokens[1]));
            CustomTuple<int, double> number = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));

            Console.WriteLine(names);
            Console.WriteLine(beers);
            Console.WriteLine(number);
        }
    }
}
