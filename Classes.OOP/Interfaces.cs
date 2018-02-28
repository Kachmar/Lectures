using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            new Student().Move();
            var ninjaWithSword = new Ninja(new Sword());
            ninjaWithSword.Move();
            ninjaWithSword.Attack();

            var ninjaWithNunjucks = new Ninja(new Nunjucks());
            ninjaWithNunjucks.Move();
            ninjaWithNunjucks.Attack();
            var advancedNinja = new AdvancedNinja(new IWeapon[] { new Sword(), new Sword(), new Nunjucks() });
            advancedNinja.Attack();

            IWarrior[] army = new IWarrior[] { ninjaWithNunjucks, advancedNinja, ninjaWithSword };
            foreach (var warrior in army)
            {

                //TODO Change the interface inheritance IWarrior:IHuman
                //warrior.Move( );

                warrior.Attack();
            }
            Console.ReadLine();
        }

        public class Student : IHuman
        {

            public void Move()
            {
                Console.WriteLine("Got to University");
            }
        }

        public class AdvancedNinja : IHuman, IWarrior
        {
            private IWeapon[] weapons;

            public AdvancedNinja(IWeapon[] weapons)
            {
                this.weapons = weapons;
            }
            public void Move()
            {
                Console.WriteLine("Got to battle field");
            }

            public void Attack()
            {
                foreach (var weapon in this.weapons)
                {
                    weapon.Strike();
                }
            }
        }

        public class Ninja : IHuman, IWarrior
        {
            private IWeapon weapon;

            public Ninja(IWeapon weapon)
            {
                this.weapon = weapon;
            }
            public void Move()
            {
                Console.WriteLine("Got to battle field");
            }

            public void Attack()
            {
                weapon.Strike();
            }
        }

        public interface IWeapon
        {
            void Strike();
        }
        public interface IHuman
        {
            void Move();
        }
        public interface IWarrior
        {
            void Attack();
        }

        public class Sword : IWeapon
        {
            public void Strike()
            {
                Console.WriteLine($"{nameof(Sword)} Hit");
            }
        }

        public class Nunjucks : IWeapon
        {
            public void Strike()
            {
                Console.WriteLine($"{nameof(Nunjucks)} Hit");
            }
        }
    }
}
