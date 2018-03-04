using System.Collections.Generic;
using System.IO;

namespace Unit_Tests
{
    public class FileManager : IFileManager
    {
        private const string SupportedExstension = ".csv";
        private IFileCommander fileCommander;
        public FileManager(IFileCommander fileCommander)
        {
            this.fileCommander = fileCommander;
        }

        public IFileInfo[] GetFiles(string folder)
        {
            FileInfo[] files = this.fileCommander.GetFiles(folder);

            List<FileInfo> result = new List<FileInfo>();
            foreach (var file in files)
            {
                if (file.Name.EndsWith(SupportedExstension))
                {
                    result.Add(file);
                }
            }
            return result.ToArray();
        }
    }
}