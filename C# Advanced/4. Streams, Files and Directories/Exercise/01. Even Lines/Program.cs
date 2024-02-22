using System.Text;

namespace _01._Even_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt"; 
            
            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] array = { '-', ',', '.', '!', '?' };
            int lineCount = 0;

            using StreamReader reader = new StreamReader(inputFilePath);

            StringBuilder sb = new StringBuilder();

            string line;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                if (lineCount % 2 == 0)
                {
                    foreach (char c in line)
                    {
                        if (array.Contains(c))
                        {
                            line = line.Replace(c, '@');
                        }
                    }

                    string[] temp = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                    sb.AppendLine(string.Join(' ', temp));
                }
                lineCount++;
            }


            return sb.ToString();
        }
    }
}
