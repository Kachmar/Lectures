using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Translations
    {
        public const string Sentece = "Dear {0}, I know you,{0}, your city is {1}";
    }

    class Strings
    {
        static void Main(string[] args)
        {
            //string simpleString = "Hi students";
            //string concatination = simpleString + "! " + 5;
            //string escapeChars = "My \"good\" boss, go to \n c:\\ drive";
            //string noEscapeChars = @"c:\";
            //string format = String.Format(Translations.Sentece, "Bob", "Lviv");
            //string numFormat = String.Format("{0:N}", 1234567890);
            //string percentage = String.Format("perc: {0:p}", .35);

            //int length = simpleString.Length;
            //bool isStIn = simpleString.Contains("st");
            //string sub = simpleString.Substring(3, 7);
            //string students = simpleString.Substring(3);
            //int index = simpleString.IndexOf("s", 4);
            //string replaced = simpleString.Replace("s", "S");

            ////StringBuilder example
            //Console.WriteLine("Please input 5 strings");
            //StringBuilder stringBuilder = new StringBuilder();
            //for (int i = 0; i < 5; i++)
            //{
            //    string value = Console.ReadLine();
            //    stringBuilder.Append(value);
            //}
            //Console.WriteLine($"Appended values: {stringBuilder.ToString()}");
            //Console.ReadLine();

            //TASK : output the string starting from ! sign, with next modification: cs=> c's
            //Count the number of 'et' string
            string text = @"Learn C# by stepping through the basics with Bob: get the tools, see how to write code, debug features, explore customizations, and much more ! Search for and focus on the information you need, in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar, create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you learn to develop Windows and web applications.";


















            int indexOfExclamationMark = text.IndexOf("!");
            string trimmed = text.Substring(indexOfExclamationMark);
            Console.WriteLine(trimmed.Replace("cs", "c's"));

            int indexOfet = trimmed.IndexOf("et");
            int counter = 0;
            while (indexOfet > 0)
            {
                indexOfet = trimmed.IndexOf("et", indexOfet + 1);
                ++counter;
            }

            //int counter = 0;
            //for (int i = 0; i < trimmed.Length - 1; i++)
            //{
            //    string candidate = trimmed.Substring(i, 2);
            //    if (candidate == "et")
            //    {
            //        counter++;
            //    }
            //}

            Console.WriteLine("Number of et: " + counter);
            Console.ReadLine();
        }
    }
}
