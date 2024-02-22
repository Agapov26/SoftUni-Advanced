namespace _02._Clear_Skies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] airspace = new char[n, n];
            int jetRow = 0;
            int jetCol = 0;
            int enemyCount = 0;
            int armor = 300;

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    airspace[i, j] = row[j];
                    if (airspace[i, j] == 'J')
                    {
                        jetRow = i;
                        jetCol = j;
                    }
                    else if (airspace[i, j] == 'E')
                    {
                        enemyCount++;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                int newRow = jetRow;
                int newCol = jetCol;

                switch (command)
                {
                    case "up":
                        newRow--;
                        break;
                    case "down":
                        newRow++;
                        break;
                    case "left":
                        newCol--;
                        break;
                    case "right":
                        newCol++;
                        break;
                }

                if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < n)
                {
                    char newPosition = airspace[newRow, newCol];

                    if (newPosition == '-')
                    {
                        airspace[jetRow, jetCol] = '-';
                        jetRow = newRow;
                        jetCol = newCol;
                        airspace[jetRow, jetCol] = 'J';
                    }

                    else if (newPosition == 'E')
                    {
                        enemyCount--;
                        airspace[jetRow, jetCol] = '-';
                        jetRow = newRow;
                        jetCol = newCol;
                        airspace[jetRow, jetCol] = 'J';

                        if (enemyCount == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            break;
                        }

                        else
                        {
                            armor -= 100;

                            if (armor <= 0)
                            {
                                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                                break;
                            }
                        }
                        
                    }

                    else if (newPosition == 'R')
                    {
                        armor = 300;
                        airspace[jetRow, jetCol] = '-';
                        jetRow = newRow;
                        jetCol = newCol;
                        airspace[jetRow, jetCol] = 'J';
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(airspace[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
