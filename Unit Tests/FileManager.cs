using System.Collections.Generic;
using System.IO;

namespace Unit_Tests
{
    class FileManager : IFileManager
    {
        private const string ProcessedFolderName = "Processed";
        private const string ErrorFolderName = "Error";

        private const string InputFolderName = "Input";

        private IFileCommander fileCommander;
        public FileManager(IFileCommander fileCommander)
        {
            this.fileCommander = fileCommander;
        }
        public IFileInfo[] GetFiles()
        {
            string folder = this.GetFolderName();
            FileInfo[] files = this.fileCommander.GetFiles(folder);

            List<FileInfo> result = new List<FileInfo>();
            foreach (var file in files)
            {
                if (file.Name.EndsWith(".csv"))
                {
                    result.Add(file);
                }
            }
            return result.ToArray();
        }

        public void MoveFileToProcessed(IFileInfo fileInfo)
        {
            fileCommander.MoveFile(fileInfo.FullName, ProcessedFolderName);
        }

        public void MoveToError(IFileInfo fileInfo)
        {
            fileCommander.MoveFile(fileInfo.FullName, ErrorFolderName);
        }

        private string GetFolderName()
        {
            return Directory.GetCurrentDirectory(  )+"\\"+ InputFolderName;
        }
    }
}