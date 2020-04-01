using System;

namespace Challenge
{

    class Program
    {
        public static void Main()
        {
            var ninjaWithSword = new Ninja(new Sword());
            Ninja ninjaWithNunjack = new Ninja(new Nunjucks());
            Trooper trooper = new Trooper();
            AdvancedNinja advancedNinja = new AdvancedNinja(new IWeapon[] { new Nunjucks(), new Sword() });
            IWarrior[] warriors = new IWarrior[] { ninjaWithNunjack, ninjaWithSword, trooper, advancedNinja };

            // Fight
            Console.WriteLine("Fight!...");
            Console.WriteLine();
            foreach (var warrior in warriors)
            {
                warrior.Move();
                warrior.Attack();
                if (warrior is IStealth)
                {
                    IStealth stealthWarior = ((IStealth)warrior);
                    stealthWarior.EnableInvisibility();
                }
            }

            // Now everybody retreat

            Console.WriteLine("Retreating...");
            Console.WriteLine();
            Human man = new Human();
            IHuman[] humans = { ninjaWithNunjack, ninjaWithSword, advancedNinja, trooper, man };
            foreach (var human in humans)
            {
                human.Move();
            }
            Console.ReadLine();

            //Tasks: 
            // - Fix build error
            // - Make the AdvancedNinja to enable invisiblity during fight
            //
        }
    }
}
