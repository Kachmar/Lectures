using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowValues = ReadRow();
            FileWriter fileWriter = new FileWriter("StudentInfo.txt", rowValues, new IProcessor[] { new DurationProcessor(), new StudentNameProcessor() });
        }

        private static string[] ReadRow()
        {
            return TODO_IMPLEMENT_ME;
        }
    }
    internal class FileWriter
    {
        public FileWriter(string fileName, string[] rowValues, IProcessor[] processors)
        {
            TODO_IMPLEMENT_ME();
        }
    }
    internal class StudentNameProcessor : IProcessor
    {
        public string Process(string[] rowValues)
        {
            return rowValues[5].Split(' ')[0];
        }
    }
    internal class DurationProcessor : IProcessor
    {
    }
}
