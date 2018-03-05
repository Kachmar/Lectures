using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unit_Tests
{
    class Program
    {
        private const string InputFolderName = "Input";

        static void Main(string[] args)
        {
            FileProcessor fileProcessor = new FileProcessor(new FileCommander(),
                null,
                new StudentInfoProcessor(new IConverter[] { new NameConverter(), new LastNameConverter(), new PhoneConverter(), new DistanceLearningConverter(), new DurationConverter() }));
            FileManager fileManager = new FileManager(new FileCommander());
            while (true)
            {
                var files = fileManager.GetFiles(GetFolderName());
                if (files.Any())
                {
                    foreach (var fileInfo in files)
                    {
                        fileProcessor.Process(fileInfo);
                    }
                }

                Thread.Sleep(1000);
            }
        }
        private static string GetFolderName()
        {
            return Directory.GetCurrentDirectory() + "\\" + InputFolderName;
        }
    }
}
