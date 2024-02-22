namespace _03._Copy_Binary_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\copyMe.png"; 
            string outputFilePath = @"..\..\..\copyMe-copy.png"; 
            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath) 
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write)) 
                {
                    byte[] buffer = new byte[4096];
                    int byteRead;

                    while ((byteRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputStream.Write(buffer, 0, byteRead);
                    }
                }
            }
        }
    }
}
