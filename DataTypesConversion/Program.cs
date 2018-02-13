using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1 + 1;
            int b = a + 10;
            byte c = (byte)(b + 2);
            decimal x = (decimal)b;
        }
    }
}
