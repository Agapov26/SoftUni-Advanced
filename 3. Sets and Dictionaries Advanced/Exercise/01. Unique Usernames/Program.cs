namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            HashSet<string> unique = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                unique.Add(user);
            }

            foreach (string user in unique)
            {
                Console.WriteLine(user);
            }
        }
    }
}
