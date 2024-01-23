namespace _05._Copy_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            Directory.CreateDirectory(outputPath);
            var files = Directory.GetFiles(inputPath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string copyDestination = Path.Combine(outputPath, fileName);
                File.Copy(file, copyDestination);
            }
        }
    }
}
