namespace _02._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {   
                

                int letters = lines[i].Where(char.IsLetter).Count();
                int punctuation = lines[i].Where(char.IsPunctuation).Count();

                lines[i] = $"Line {i + 1}:  {lines[i]} ({letters}) ({punctuation})";
            }

            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
public class LineNumbers 
{ 
    public static void ProcessLines(string inputFilePath, string outputFilePath) 
    {

    } 
}