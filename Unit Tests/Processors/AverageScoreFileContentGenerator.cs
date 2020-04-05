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
            throw new NotImplementedException();
        }

        public string GetFileName(string originalFileName)
        {
            throw new NotImplementedException();
        }
    }
}