using System;

namespace Unit_Tests
{
    public class FileProcessor
    {
        private const string ProcessedFolderName = "Processed";
        private const string ErrorFolderName = "Error";
        private IFileContentGenerator[] fileContentGenerators;
        private IFileCommander fileCommander;

        public FileProcessor(
            IFileCommander fileCommander,
            IFileContentGenerator[] fileContentGenerators)
        {
            this.fileContentGenerators = fileContentGenerators;
            this.fileCommander = fileCommander;
        }

        public void Process(IFileInfo fileInfo)
        {
            try
            {
                foreach (var fileContentGenerator in fileContentGenerators)
                {
                    string fileContent = fileContentGenerator.Process(fileInfo);
                    this.fileCommander.SaveFile(fileContentGenerator.GetFileName(fileInfo.Name), fileContent);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Failed to process file {fileInfo.Name}, because: {ex.Message}");
                try
                {
                    this.fileCommander.MoveFile(fileInfo.FullName, ErrorFolderName);
                }
                catch (Exception subException)
                {
                    Console.WriteLine($"Failed to move the file {fileInfo.Name} to error folder, because: {subException.Message}");
                }
                return;
            }

            try
            {
                this.fileCommander.MoveFile(fileInfo.FullName, ProcessedFolderName);
            }
            catch (Exception subException)
            {
                Console.WriteLine($"Failed to move the file {fileInfo.Name} to processed folder, because: {subException.Message}");
            }
        }
    }
}