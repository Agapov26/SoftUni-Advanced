namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(", ");

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "IN")
                {
                    parking.Add(command[1]);
                }
                if (command[0] == "OUT")
                {
                    parking.Remove(command[1]);
                }
            }

            if (parking.Any())
            {
                foreach (string car in parking)
                {
                    Console.WriteLine(car);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
