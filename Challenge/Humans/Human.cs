using System;

namespace Challenge
{
    internal class Human
    {
        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moves.");
        }
    }
}