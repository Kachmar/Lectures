using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_Tests
{
    public class UniqueNamesFileContentGenerator : IFileContentGenerator
    {
        private readonly ISplitLinesProvider _linesProvider;
        private readonly INameConverter _nameConverter;

        public UniqueNamesFileContentGenerator(ISplitLinesProvider linesProvider, INameConverter nameConverter)
        {
            _linesProvider = linesProvider;
            _nameConverter = nameConverter;
        }

        public string Process(IFileInfo fileInfo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string[]> linesElements = _linesProvider.GetLinesElements(fileInfo);
            List<string> uniqueNames = new List<string>();
            foreach (var lineElements in linesElements)
            {
                string name = _nameConverter.Convert(lineElements);
                if (uniqueNames.Contains(name))
                {
                    continue;
                }
                uniqueNames.Add(name);
                stringBuilder.Append(name);
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

        public string GetFileName(string originalFileName)
        {
            int index = originalFileName.IndexOf(".csv");
            return originalFileName.Insert(index, "_processed_unique_students");
        }
    }
}