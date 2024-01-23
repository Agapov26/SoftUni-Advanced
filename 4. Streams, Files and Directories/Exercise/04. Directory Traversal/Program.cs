﻿namespace _04._Directory_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine(); 
            string reportFileName = @"\report.txt"; 
            var reportContent = TraverseDirectory(path); 

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static Dictionary<string, List<FileInfo>> TraverseDirectory(string inputFolderPath) 
        {
            Dictionary<string, List<FileInfo>> fileDictionry = new Dictionary<string, List<FileInfo>>();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                string extension = info.Extension;

                if (!fileDictionry.ContainsKey(extension))
                {
                    fileDictionry.Add(extension, new List<FileInfo>());
                }

                fileDictionry[extension].Add(info);
            }

            return fileDictionry;
        }

        public static void WriteReportToDesktop(Dictionary<string, List<FileInfo>> fileDictionary, string reportFileName) 
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +  reportFileName;
            using StreamWriter writer = new StreamWriter(path);

            foreach (var item in fileDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                writer.WriteLine($"{item.Key}");

                foreach (var file in item.Value.OrderBy(x => x.Length))
                {
                    writer.WriteLine($"--{file.Name} - {Math.Ceiling((double) file.Length/ 1024)}kb");
                }
            }
        }
    }
}
