using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_Tests
{
    public class DurationFileContentGenerator : IFileContentGenerator
    {
        private readonly ISplitLinesProvider _linesProvider;
        private readonly IConverter[] converters;

        public DurationFileContentGenerator(ISplitLinesProvider linesProvider, IConverter[] converters)
        {
            _linesProvider = linesProvider;
            this.converters = converters;
        }

        public string Process(IFileInfo fileInfo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string[]> linesElements = _linesProvider.GetLinesElements(fileInfo);

            foreach (var lineElements in linesElements)
            {
                foreach (var converter in this.converters)
                {
                    string convertedElement = converter.Convert(lineElements);
                    stringBuilder.Append(convertedElement);
                    stringBuilder.Append("|");

                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

        public string GetFileName(string originalFileName)
        {
            int index = originalFileName.IndexOf(".csv");
            return originalFileName.Insert(index, "_processed_durations");
        }
    }
}