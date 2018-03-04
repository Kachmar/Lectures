using System;

namespace Unit_Tests
{
    public class FileProcessor
    {
        private const string ProcessedFolderName = "Processed";
        private const string ErrorFolderName = "Error";
        private IStudentInfoProcessor studentInfoProcessor;

        private IScoreProcessor scoreProcessor;
        private IFileCommander fileCommander;

        public FileProcessor(
            IFileCommander fileCommander,
            IScoreProcessor scoreProcessor,
            IStudentInfoProcessor studentInfoProcessor)

        {
            this.studentInfoProcessor = studentInfoProcessor;
            this.fileCommander = fileCommander;
            this.scoreProcessor = scoreProcessor;
        }
        public void Process(IFileInfo fileInfo)
        {
            try
            {
                string fileContent = this.studentInfoProcessor.Process(fileInfo);
                this.fileCommander.SaveFile(this.GetStudentFileName(fileInfo.Name), fileContent);
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

        private string GetStudentFileName(string originalFileName)
        {
            int index = originalFileName.IndexOf(".csv");
            return originalFileName.Insert(index, "_processed_durations");
        }
    }
}