using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_Tests
{
    public class SplitLinesProvider : ISplitLinesProvider
    {
        public List<string[]> GetLinesElements(IFileInfo fileInfo)
        {

            string[] lines = SplitIntoLines(fileInfo.Content);
            List<string[]> result = new List<string[]>();
            foreach (var line in lines.Skip(1))
            {
                var elements = line.Trim().Split(';');
                ValidateElements(elements);
                result.Add(elements);
            }

            return result;
        }

        private void ValidateElements(string[] elements)
        {
            if (elements.Length != 6)
            {
                throw new Exception("Number of elements is not incorrect");
            }
        }

        private string[] SplitIntoLines(string fileInfoContent)
        {
            string[] lineSplitChars = new string[] { "\r\n" };
            return fileInfoContent.Split(lineSplitChars, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}