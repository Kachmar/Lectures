using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProcessor fileProcessor = new FileProcessor();
            FileManager fileManager = new FileManager();
            while (true)
            {
                var files = fileManager.GetFiles();
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
    }
}
