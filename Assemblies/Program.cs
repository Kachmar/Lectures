
using System;

using WebScrambler;

namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrambler scrambler = new Scrambler();
            Console.WriteLine(scrambler.GetContent());
            Console.ReadLine( );
        }
    }
}
