using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_Tests
{
    class StudentInfoProcessor : IStudentInfoProcessor
    {
        private readonly IConverter[] converters;

        public StudentInfoProcessor(IConverter[] converters)
        {
            this.converters = converters;
        }

        public string Process(IFileInfo fileInfo)
        {
            string[] lines = SplitIntoLines(fileInfo.Content);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var line in lines.Skip(1))
            {
                var elements = line.Trim().Split(';');
                ValidateElements(elements);
                foreach (var converter in this.converters)
                {
                    string convertedElement = converter.Convert(elements);
                    stringBuilder.Append(convertedElement);

                }
            }
            return stringBuilder.ToString();
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