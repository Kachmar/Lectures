using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //infinite loop
            //for (int i = 0; i < 3;)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; false; i = 3)
            //{
            //    Console.WriteLine(i);
            //}


            //int i = 3;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);


            //int i = 3;
            //while (i > 0)
            //{
            //    i--;
            //    if (i == 2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 4; i >= 0; i--)
            //{
            //    if (i == 2)
            //        break;
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    if (i == 1)
            //        return;
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    if ( i == 1 )
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine($"x: {x}");
                    Console.WriteLine($"y: {y}");
                }
            }
            Console.ReadLine();
        }
    }
}
