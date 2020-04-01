namespace Challenge
{
    class AdvancedNinja
    {
        private IWeapon[] weapons;

        public AdvancedNinja(IWeapon[] weapons)
        {
            this.weapons = weapons;
        }

        public void Attack()
        {
            foreach (var weapon in this.weapons)
            {
                weapon.Strike();
            }
        }
    }
}