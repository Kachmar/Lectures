using System;

namespace Unit_Tests
{
    internal class FileProcessor
    {
        private IStudentInfoProcessor studentInfoProcessor;

        private IScoreProcessor scoreProcessor;

        private IFileWriter fileWriter;

        private IFileManager fileManager;
        public void Process(IFileInfo fileInfo)
        {
            try
            {
                string fileContent = this.studentInfoProcessor.Process(fileInfo);
                this.fileWriter.SaveFileContent(this.GetStudentFileName(fileInfo.Name), fileContent);
                this.fileManager.MoveFileToProcessed(fileInfo);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Failed to process file {fileInfo.Name}, because: {ex.Message}");
                try
                {
                    this.fileManager.MoveToError(fileInfo);
                }
                catch (Exception subException)
                {
                    Console.WriteLine($"Failed to move the file {fileInfo.Name} to error folder, because: {subException.Message}");
                }
            }
        }

        private string GetStudentFileName(string originalFileName)
        {
            int index = originalFileName.IndexOf(".csv");
            return originalFileName.Insert(index, "_processed_durations");
        }
    }
}