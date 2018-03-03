using System.IO;

namespace Unit_Tests
{
    class FileWriter : IFileWriter
    {
        public void SaveFileContent(string fileName, string fileContent)
        {
            File.WriteAllText(fileName, fileContent);
        }
    }
}