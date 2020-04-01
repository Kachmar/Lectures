using System;

namespace Challenge
{
    class Trooper : Human, IWarrior
    {
        public void Attack()
        {
            Console.WriteLine($"{nameof(Trooper)} punches.");
        }
    }
}