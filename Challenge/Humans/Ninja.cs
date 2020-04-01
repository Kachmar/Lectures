using System;

namespace Challenge
{
    internal class Ninja : Human, IStealth, IWarrior
    {
        private IWeapon weapon;

        public Ninja(IWeapon newWeapon)
        {
            this.weapon = newWeapon;
        }

        public void Attack()
        {
            if (weapon != null)
            {
                weapon.Strike();
            }
        }

        public void EnableInvisibility()
        {
            Console.WriteLine("Nobody can see me.");
        }
    }
}