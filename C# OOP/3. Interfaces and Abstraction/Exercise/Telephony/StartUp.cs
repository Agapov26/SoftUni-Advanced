namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            string[] numbers = Console.ReadLine().Split();
            foreach (var number in numbers)
            {
                try
                {
                    smartphone.CallNumber(number);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            string[] link = Console.ReadLine().Split();

            foreach (var url in link)
            {
                try
                {
                    smartphone.BrowseWebsite(url);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

        }
    }
}
