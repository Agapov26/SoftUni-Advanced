namespace _02._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader inputStreamReader = new StreamReader(inputFilePath);
            using (inputStreamReader)
            {
                StreamWriter outputStreamWriter = new StreamWriter(outputFilePath);
                using (outputStreamWriter)
                {
                    string line;
                    int lineCount = 0;

                    while ((line = inputStreamReader.ReadLine()) != null)
                    {
                        outputStreamWriter.WriteLine($"{lineCount}. {line}");
                        lineCount++;
                    }
                }
            }
        }
    }
}
