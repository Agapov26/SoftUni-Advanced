namespace ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ListyIterator<string> listy = new ListyIterator<string>(input.Skip(1).ToList());

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Print":
                        try
                        {
                            listy.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "PrintAll":
                        foreach (var item in listy)
                        {
                            Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
