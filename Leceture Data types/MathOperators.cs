using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MathOperators
    {
        static void Main(string[] args)
        {
            int addition = 4 + 5;
            int substraction = 9 - 4;
            int multiplication = 2 * 2;
            int division = 10 / 5;
            int remainder = 10 % 4;

            addition = addition + 1;
            ++addition;
            int suffixIncrement = addition++;
            int prefixIncrement = ++addition;
        }
    }
}
