namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var invites = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "PARTY")
                {
                    break;
                }

                invites.Add(command);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (invites.Contains(command))
                {
                    invites.Remove(command);
                }
            }

            Console.WriteLine(invites.Count);

            foreach (string guest in invites)
            {
                if (char.IsDigit(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (string guest in invites)
            {
                if (!char.IsDigit(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
