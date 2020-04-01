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
            PrinterBase textPrinter = new TextPrinterWithDateTime("Jungle book", new[] { "Introduction", "Contents" });
          
            PrinterBase imagePrinter = new ImagePrinter("Jungle book", new byte[][] { new byte[] { 40, 45, 6 } });
            
            Print(textPrinter);
            Print(imagePrinter);
            //Deriving from TextPrinter
            //TextPrinterWithExtendedHeading textPrinterWithExtendedHeading = new TextPrinterWithExtendedHeading("Jungle book", new[] { "Introduction", "Contents" });
            //textPrinterWithExtendedHeading.PrintNextPage();
            //polymorphism
            //PrinterBase printerA = new TextPrinter("Jungle book", new[] { "Introduction", "Contents" });
            //PrinterBase printerB = new ImagePrinter("Jungle book", new byte[][] { new byte[] { 40, 45, 6 } });
            //printerB.PrintNextPage();
            //printerA.PrintNextPage();

            //public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
            //private: The type or member can be accessed only by code in the same class or struct.
            //protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
            //internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
            //protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
            //private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.

            //public: публичный, общедоступный класс или член класса.Такой член класса доступен из любого места в коде, а также из других программ и сборок.
            //private: закрытый класс или член класса.Представляет полную противоположность модификатору public. Такой закрытый класс или член класса доступен только из кода в том же классе или контексте.
            //protected: такой член класса доступен из любого места в текущем классе или в производных классах.При этом производные классы могут располагаться в других сборках.
            //internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, однако он недоступен для других программ и сборок(как в случае с модификатором public).
            //protected internal: совмещает функционал двух модификаторов.Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов.
            //private protected: такой член класса доступен из любого места в текущем классе или в производных классах, которые определены в той же сборке.

            // virtual - означає, що в дочірньому класі можна переоприділити.
            // ovveride  - переоприділяє
            // abstract - якщо клас, то означає, що його лише можна наслідувати. Якщо до методу чи властивості, тоді означає, що вона мусить бути перевизначена в дочірньому класі.

            //Ask students to Create a printer that would derive from ImagePrinter, and would not print Header and Footer, just body
            Console.ReadLine();
        }

        private static void Print(PrinterBase printer)
        {
            printer.PrintNextPage();
        }
    }

    internal abstract class PrinterBase
    {
        private string bookTitle;
        protected int index = 0;

        protected PrinterBase(string bookTitle)
        {
            this.bookTitle = bookTitle;
        }

        private void PrintFooter()
        {
            Console.WriteLine(this.index++);
        }

        protected virtual void PrintHeader()
        {
            Console.WriteLine(bookTitle);
        }

        protected abstract void PrintBody();

        public void PrintNextPage()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }

    internal class ImagePrinter : PrinterBase
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

    internal class TextPrinter : PrinterBase
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

    internal class TextPrinterWithDateTime : TextPrinter
    {
        public TextPrinterWithDateTime(string bookTitle, string[] texts) : base(bookTitle, texts)
        {
        }

        public void Test()
        {

        }
        protected override void PrintHeader()
        {
            base.PrintHeader();
            Console.WriteLine(DateTime.Now);
        }
    }
   

    //public class CastingSample
    //{
    //    public void Cast()
    //    {
    //        PrinterBase printer = new TextPrinter();
    //        if (printer is Ima)
    //        {
    //            ((TextPrinter)printer).PrintNextPage();
    //            TextPrinter textPrinter = (printer as TextPrinter);
    //            textPrinter.PrintNextPage();
    //        }

    //        if (!(printer is TextPrinterWithExtendedHeading))
    //        {
    //            ((TextPrinterWithExtendedHeading)printer).PrintNextPage();
    //            TextPrinter textPrinter = (printer as TextPrinterWithExtendedHeading);
    //            textPrinter.PrintNextPage();
    //        }
    //    }
    //}
}
