using System.Collections.Generic;
using System.IO;

namespace Unit_Tests
{
    class FileCommander : IFileCommander
    {

        public FileInfo[] GetFiles(string folder)
        {
            var files = Directory.GetFiles(folder);
            return ReadFiles(files);
        }

        private FileInfo[] ReadFiles(string[] files)
        {
            List<FileInfo> result = new List<FileInfo>();
            foreach (var file in files)
            {
                string content = File.ReadAllText(file);
                FileInfo fileInfo = new FileInfo();
                fileInfo.Content = content;
                fileInfo.Name = Path.GetFileName(file);
                fileInfo.FullName = file;
                result.Add(fileInfo);
            }
            return result.ToArray();
        }

        public void MoveFile(string fullName, string targetFolderName)
        {
            string newFileName = Path.GetFileName(fullName);
            string targetFolder = Path.Combine(Directory.GetCurrentDirectory(), targetFolderName);
            Directory.CreateDirectory(targetFolder);
            File.Delete(Path.Combine(targetFolder, newFileName));
            File.Move(fullName, Path.Combine(targetFolder, newFileName));
        }

    }
}