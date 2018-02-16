using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Operands
    {
        static void Main(string[] args)
        {
            /////////////// == /////////////////
            //int a = 10;
            //int b = 4;
            //bool c = (a == b); // false

            //////////////// != ///////////////
            //int a = 10;
            //int b = 4;
            //bool c = a != b;    // true
            //bool d = a != 10;     // false

            ///////////////// < ////////////////
            //int a = 10;
            //int b = 4;
            //bool c = a < b; // false

            ///////////////// > /////////////////
            //int a = 10;
            //int b = 4;
            //bool c = a > b;     // true
            //bool d = a > 25;    // false
            //bool x = a > 10;       //false
            /////////////// <= /////////////////
            //int a = 10;
            //int b = 4;
            //bool c = a <= b;     // false
            //bool d = a <= 25;    // true
            //bool x = a <= 10;       //true
            /////////////// >= ////////////////
            //int a = 10;
            //int b = 4;
            //bool c = a >= b;     // true
            //bool d = a >= 25;    // false

            ////////////// |  /////////////////
            //bool negative = (false | false);
            //bool positive = false | true;
            //bool positiveAsWell = GetTrueValue() | GetTrueValue();

            /////////////// ||  //////////////
            //bool negative = false || false;
            //bool positive = false || true;
            //bool positiveAsWell = GetTrueValue() || GetTrueValue();

            //////////////// &  ///////////////
            //bool positive = true & true;
            //bool negative = false & true;
            //bool negativeAsWell = GetFalseValue() & GetFalseValue();


            //////////////// &&  ///////////////
            //bool positive = true && true;
            //bool negative = false && true;
            //bool negativeAsWell = GetFalseValue() && GetFalseValue();

            /////////////// !  /////////////////
            //bool a = true;
            //bool b = !a;    // false
            //bool x = !!a;

            ///////////// ^ //////////////////
            /// XOR exclusive or
            bool positive = true ^ false;
            bool negative = true ^ true;
            bool negativeAsWell = false ^ false;
            Console.ReadLine();
        }

        static bool GetTrueValue()
        {
            Console.WriteLine("Returning true value");
            return true;
        }

        static bool GetFalseValue()
        {
            Console.WriteLine("Returning false value");
            return false;
        }
    }
}