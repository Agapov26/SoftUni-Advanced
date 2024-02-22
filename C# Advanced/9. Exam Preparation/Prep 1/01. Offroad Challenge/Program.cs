namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> additionalFuel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> neededFuel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            int altitude = 1;
            bool notReached = false;
            while (initialFuel.Count > 0)
            {
                int initialFuels = initialFuel.Pop();
                int additionalFuels = additionalFuel.Dequeue();
                int neededFuels = neededFuel.Dequeue();

                int fuel = initialFuels - additionalFuels;

                if (fuel >= neededFuels)
                {
                    Console.WriteLine($"John has reached: Altitude {altitude++}");
                }

                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitude--}");
                    notReached = true;
                    break;
                }
            }

            if (notReached)
            {
                Console.WriteLine("John failed to reach the top.");

                if (altitude == 0)
                {
                    Console.WriteLine("John didn't reach any altitude.");
                }

                else
                {
                    Console.Write($"Reached altitudes: ");

                    for (int i = 0; i < altitude; i++)
                    {
                        Console.Write($"Altitude {i + 1}");

                        if (i < altitude - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}
