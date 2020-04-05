using System;
using System.Linq;

namespace Unit_Tests
{
    public class AverageScoreFileContentGenerator : IFileContentGenerator
    {
        private readonly ISplitLinesProvider _splitLinesProvider;

        public AverageScoreFileContentGenerator(ISplitLinesProvider splitLinesProvider)
        {
            _splitLinesProvider = splitLinesProvider;
        }

        public string Process(IFileInfo fileInfo)
        {
            var linesElements = _splitLinesProvider.GetLinesElements(fileInfo);
            if (!linesElements.Any())
            {
                return string.Empty;
            }

            int total = 0;
            int count = 0;
            foreach (var lineElements in linesElements)
            {
                total += int.Parse(lineElements[2].Trim());
                count++;
            }

            return (total / count).ToString();
        }

        public string GetFileName(string originalFileName)
        {
            if (string.IsNullOrEmpty(originalFileName))
            {
                throw new Exception("Empty file name");
            }

            int index = originalFileName.IndexOf(".csv");
            if (index < 0)
            {
                throw new Exception("File is not .csv");
            }
            return originalFileName.Insert(index, "_processed_average_score");
        }
    }
}