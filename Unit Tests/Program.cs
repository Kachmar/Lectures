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
            var splitLinesProvider = new SplitLinesProvider();

            var averageScoreFileContentGenerator = new AverageScoreFileContentGenerator(splitLinesProvider);
            var uniqueNamesFileContentGenerator = new UniqueNamesFileContentGenerator(splitLinesProvider, new NameConverter());
            var durationFileContentGenerator = new DurationFileContentGenerator(
                splitLinesProvider,
                new IConverter[]
                {
                    new NameConverter(), new LastNameConverter(), new PhoneConverter(),
                    new DistanceLearningConverter(), new DurationConverter()
                });

            var fileContentGenerators = new IFileContentGenerator[] { averageScoreFileContentGenerator, durationFileContentGenerator, uniqueNamesFileContentGenerator };

            var fileProcessor = new FileProcessor(new FileCommander(), fileContentGenerators);
            var fileManager = new FileManager(new FileCommander());

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
