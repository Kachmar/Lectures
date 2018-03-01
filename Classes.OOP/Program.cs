using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextPrinter textPrinter = new TextPrinter();
            textPrinter.PrintNextPage("Introduction");
            textPrinter.PrintNextPage("Contents");
            ImagePrinter imagePrinter = new ImagePrinter();
            imagePrinter.PrintNextPage(new byte[] { 40, 45, 6 });
            Console.ReadLine();
        }
    }

    internal abstract class PrinterBase
    {
        private const string BookTitle = "Book of jungle";
        private int index = 1;

        internal void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        public void PrintHeader()
        {
            Console.WriteLine(BookTitle);
        }
    }

    internal class ImagePrinter : PrinterBase
    {
        public void PrintNextPage(byte[] imageBytes)
        {
            PrintHeader();
            PrintBody(imageBytes);
            PrintFooter();
        }

        private void PrintBody(byte[] imageBytes)
        {
            string image = Encoding.Default.GetString(imageBytes);
            Console.WriteLine(image);
        }
    }

    internal class TextPrinter : PrinterBase
    {

        public void PrintNextPage(string text)
        {
            PrintHeader();
            PrintBody(text);
            PrintFooter();
        }

        private void PrintBody(string text)
        {
            Console.WriteLine(text);
        }
    }
}
