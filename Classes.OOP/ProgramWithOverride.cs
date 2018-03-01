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
            TextPrinter textPrinter = new TextPrinter("Jungle book", new[] { "Introduction", "Contents" });

            textPrinter.PrintNextPage();
            textPrinter.PrintNextPage();
            ImagePrinter imagePrinter = new ImagePrinter("Jungle book", new byte[][] { new byte[] { 40, 45, 6 } });
            imagePrinter.PrintNextPage();
            TextPrinterWithExtendedHeading textPrinterWithExtendedHeading = new TextPrinterWithExtendedHeading("Jungle book", new[] { "Introduction", "Contents" });
            textPrinterWithExtendedHeading.PrintNextPage();
            //polymorphism
            PrinterBase printerA = new TextPrinter("Jungle book", new[] { "Introduction", "Contents" });
            PrinterBase printerB = new ImagePrinter("Jungle book", new byte[][] { new byte[] { 40, 45, 6 } });
            printerB.PrintNextPage();
            printerA.PrintNextPage();
            //
            Console.ReadLine();
        }
    }

    public abstract class PrinterBase
    {
        protected string bookTitle;
        protected int index = 0;

        protected PrinterBase(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        public void PrintNextPage()
        {
            this.PrintHeader();
            PrintBody();
            this.PrintFooter();
        }

        protected abstract void PrintBody();


        protected void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        protected virtual void PrintHeader()
        {
            Console.WriteLine(bookTitle);
        }
    }

    public class ImagePrinter : PrinterBase
    {
        private byte[][] imageBytesCollection;
        public ImagePrinter(string bookTitle, byte[][] imageBytesCollection) : base(bookTitle)
        {
            this.imageBytesCollection = imageBytesCollection;
        }

        protected override void PrintBody()
        {
            string image = Encoding.Default.GetString(imageBytesCollection[this.index]);
            Console.WriteLine(image);
        }

    }
    public class TextPrinterWithExtendedHeading : TextPrinter
    {
        public TextPrinterWithExtendedHeading(string bookTitle, string[] texts)
            : base(bookTitle, texts)
        {
        }


        protected override void PrintHeader()
        {
            base.PrintHeader();
            Console.WriteLine(DateTime.Now);
        }

    }
    public class TextPrinter : PrinterBase
    {
        private string[] texts;
        public TextPrinter(string bookTitle, string[] texts) : base(bookTitle)
        {
            this.texts = texts;
        }

        protected override void PrintBody()
        {
            Console.WriteLine(this.texts[this.index]);
        }
    }
}
