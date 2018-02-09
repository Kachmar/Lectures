using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////double//////////////
            const double pi = 3.14159;
            Console.WriteLine("double values:");
            double tryUsedouble = 12.4343;
            tryUsedouble = 14.333;
            Console.WriteLine(double.MaxValue.ToString());
            Console.WriteLine(double.MinValue.ToString());
            ////////////////////int//////////////////
            Console.WriteLine("int values:");

            Console.WriteLine(int.MaxValue.ToString());
            Console.WriteLine(int.MinValue.ToString());
            int addition = 5 + 5;
            int division = 10 / 2;
            ///////////////////boolean//////////////////////
            Console.WriteLine("boolean values:");
            string inputString = Console.ReadLine();
            bool hasAnyInput = String.IsNullOrWhiteSpace(inputString);

            if (hasAnyInput)
            {
                Console.WriteLine("We received some text");
            }
            else
            {
                Console.WriteLine("Empty value :(");
            }

            var logicalOrResult = true || false;
            var logicalAndResult = true && false;
            bool falseValue = false;
            Console.WriteLine(bool.FalseString);
            Console.WriteLine(falseValue);
            Console.WriteLine(true);
            ///////////////////string////////////////
            string literal = "Hi students";
            char secondChar = literal[1];
            string concatination = literal + secondChar;
            string anotherConcatination = "Hi " + "students";
            //escape chars;
            Console.WriteLine("Hello\tWorld\n\n");
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
