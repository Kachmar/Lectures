using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.OOP
{
    class Program
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

    public abstract class PrinterBase
    {
        protected const string BookTitle = "Book of jungle";
        protected int index = 0;
        protected void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        protected void PrintHeader()
        {
            Console.WriteLine(BookTitle);
        }
    }
    public class ImagePrinter : PrinterBase
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

    public class TextPrinter : PrinterBase
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
