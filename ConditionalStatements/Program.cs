using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("true...");
            }

            if (1 > 2)
            {
                Console.WriteLine("false...");
            }
            
            Console.WriteLine("y or n ?");
            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.WriteLine("so you agree");
            }
            else
            {
                Console.WriteLine("so you disagree");
            }

            //same logic as previous with ternary operator
            Console.WriteLine( input == "y" ? "so you agree" : "so you disagree" );
            //what if you type z ?

            if (input == "y")
            {
                Console.WriteLine("so you agree");
            }
            else if (input == "n")
            {
                Console.WriteLine("so you disagree");
            }
            else
            {
                Console.WriteLine("I don't understand.");
            }

            switch (input)
            {
                case "y":
                    {
                        Console.WriteLine("so you agree");
                        break;
                    }
                case "n":
                    {
                        Console.WriteLine("so you disagree");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand.");
                        break;
                    }
            }
        }
    }
}
