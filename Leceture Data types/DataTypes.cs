using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            ////////////////////int//////////////////
            Console.WriteLine("int values:");
            int commonInt = -77;
            int bitWiseSetInt = 0b11;//3
            int hexadecimalSetInt = 0xff;//255

            int addition = 5 + 5;
            int division = 10 / 2;
            Console.WriteLine(int.MaxValue.ToString());
            Console.WriteLine(int.MinValue.ToString());

            ////////////////double//////////////
            Console.WriteLine("double values:");
            const double pi = 3.14159;
            //pi = 9.5;
            double tryUsedouble = 12.4343;
            tryUsedouble = 14.333;
            tryUsedouble = 2.3 + 3.4;
            int integer = 4;
            tryUsedouble = integer;
            // integer = tryUsedouble;
            Console.WriteLine(double.MaxValue.ToString());
            Console.WriteLine(double.MinValue.ToString());

            ///////////////////boolean//////////////////////
            const string boolString = "boolean values:";
            Console.WriteLine(boolString);
            string inputString = Console.ReadLine();
            bool isEmtpyInput = String.IsNullOrWhiteSpace(inputString);

            if (isEmtpyInput)
            {
                Console.WriteLine("Empty value :(");
            }
            else
            {
                Console.WriteLine("We received some text");
            }

            var logicalOrResult = true || false;
            var logicalAndResult = true && false;
            bool falseValue = false;
            Console.WriteLine(bool.FalseString);
            Console.WriteLine(falseValue);
            Console.WriteLine(true);
            ///////////////////string////////////////
            string literal = "Hi students";
            char hChar = 'h';
            string singleCharString = hChar.ToString();
            char secondChar = literal[1];
            string concatination = literal + secondChar;
            string anotherConcatination = "Hi " + "students";
            //escape chars;
            Console.WriteLine("Hello\tWorld\n\n:)");
            ///////////////////enum/////////////////
            Mood myCurrentMood = Mood.Normal;
            if (Mood.Bad == myCurrentMood)
            {
                Console.WriteLine("I am upset");
            }
            else if (Mood.Good == myCurrentMood)
            {
                Console.WriteLine("I am happy");

            }
            Console.ReadLine();
        }
    }

    enum Mood
    {
        Bad,
        Normal,
        Good
    }
}
