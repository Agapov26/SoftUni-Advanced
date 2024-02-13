namespace _02._Fishing_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] fishingArea = new char[n, n];

            bool whirlpool = false;
            int boatRow = 0, boatCol = 0, fish = 0;
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    char current = line[col];

                    if (current == 'S')
                    {
                        boatRow = row;
                        boatCol = col;
                    }
                    fishingArea[row, col] = current;
                }
            }

            Func<int, int> indexCheck = pos =>
            {
                if (pos == n)
                {
                    return 0;
                }
                else if (pos < 0)
                {
                    return n - 1;
                }
                return pos;
            };

            Action<int> catchCheck = caught =>
            {
                if (caught > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {caught} tons.");
                }
            };

            string input;
            while ((input = Console.ReadLine()) != "collect the nets")
            {
                if (!whirlpool)
                {
                    fishingArea[boatRow, boatCol] = '-';
                    switch (input)
                    {
                        case "up":
                            boatRow--;
                            break;
                        case "down":
                            boatRow++;
                            break;
                        case "left":
                            boatCol--;
                            break;
                        case "right":
                            boatCol++;
                            break;
                    }

                    boatRow = indexCheck(boatRow);
                    boatCol = indexCheck(boatCol);


                    if (Char.IsDigit(fishingArea[boatRow, boatCol]))
                    {
                        fish += int.Parse(fishingArea[boatRow, boatCol].ToString());
                        fishingArea[boatRow, boatCol] = '-';
                    }

                    if (fishingArea[boatRow, boatCol] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{boatRow},{boatCol}]");
                        whirlpool = true;
                        return;
                    }

                    fishingArea[boatRow, boatCol] = 'S';
                }

            }
            if (whirlpool)
            {
                return;
            }
            if (fish < 20)
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fish} tons of fish more.");
            }
            else
            {
                Console.WriteLine($"Success! You managed to reach the quota!");
            }
            catchCheck(fish);


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(fishingArea[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
