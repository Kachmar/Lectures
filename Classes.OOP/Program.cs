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
            textPrinter.PrintNextPage("This is the beginning of the story");

            ImagePrinter imagePrinter = new ImagePrinter();
            imagePrinter.PrintNextPage(new byte[] { 40, 45, 6 });
            Console.ReadLine();

           //We have code duplication, and the ingeritance comes to the rescue. ProgramWithBaseClass has ready solution
        }
    }

    internal class ImagePrinter
    {
        private const string BookTitle = "Book of jungle";
        private int index = 1;

        private void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        private void PrintHeader()
        {
            Console.WriteLine(BookTitle);
        }

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

    internal class TextPrinter
    {
        private const string BookTitle = "Book of jungle";
        private int index = 1;

        private void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        private void PrintHeader()
        {
            Console.WriteLine(BookTitle);
        }

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
