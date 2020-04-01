using System;

namespace Challenge
{
    internal class Sword : IWeapon
    {
        public void Strike()
        {
            Console.WriteLine($"{nameof(Sword)} Hit");
        }
    }
}