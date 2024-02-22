namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();

            random.Add("cat");
            random.Add("dog");

            Console.WriteLine(random.RandomString());
        }
    }
}
