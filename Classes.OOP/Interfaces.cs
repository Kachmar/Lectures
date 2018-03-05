using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.OOP
{
    interface IContract
    {
        int x { get; set; }
        string GetText();

    }

    class Program
    {
        public static void Main()
        {
            var ninjaWithSword = new Ninja(new Sword());
            Ninja ninjaWithNunjack = new Ninja(new Nunjucks());

            Trooper trooper = new Trooper();

            IWarrior[] warriors = new IWarrior[] { ninjaWithNunjack, ninjaWithSword, trooper };

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

            // now I want my ninja to use nunjucks...use the interface IWarrior

            //now I want a human...create an IHuman that can move interface

            //Now I want to have a collection of all people: ninjas and humans.
            Console.ReadLine();
        }
    }

    interface IWarrior : IHuman
    {
        void Attack();
    }

    interface IStealth
    {
        void EnableInvisibility();
    }

    interface IHuman
    {
        void Move();
    }

    interface IWeapon
    {
        void Strike();
    }

    internal class Human : IHuman
    {
        public void Move()
        {
            Console.WriteLine("Go to work");
        }
    }

    internal class Nunjucks : IWeapon
    {
        public void Strike()
        {
            Console.WriteLine($"{nameof(Nunjucks) } Hit");
        }
    }

    internal class Sword : IWeapon
    {
        public void Strike()
        {
            Console.WriteLine($"{nameof(Sword)} Hit");
        }
    }


    class Trooper : IWarrior
    {

        public void Move()
        {
            Console.WriteLine($"{nameof(Trooper)} goes to the battle field.");
        }

        public void Attack()
        {
            Console.WriteLine($"{nameof(Trooper)} punches.");
        }
    }

    internal class Ninja : IStealth, IWarrior
    {
        private IWeapon weapon;

        public Ninja(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack()
        {
            weapon.Strike();
        }

        public void Move()
        {
            Console.WriteLine("Go to battle field");
        }

        public void EnableInvisibility()
        {
            Console.WriteLine("Nobody can see me.");
        }
    }


    public class CastingSample
    {
        public void Cast()
        {
            Adv
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        new Student().Move();
    //        var ninjaWithSword = new Ninja(new Sword());
    //        ninjaWithSword.Move();
    //        ninjaWithSword.Attack();

    //        var ninjaWithNunjucks = new Ninja(new Nunjucks());
    //        ninjaWithNunjucks.Move();
    //        ninjaWithNunjucks.Attack();
    //        var advancedNinja = new AdvancedNinja(new IWeapon[] { new Sword(), new Sword(), new Nunjucks() });
    //        advancedNinja.Attack();

    //        IWarrior[] army = new IWarrior[] { ninjaWithNunjucks, advancedNinja, ninjaWithSword };
    //        foreach (var warrior in army)
    //        {

    //            //TODO Change the interface inheritance IWarrior:IHuman
    //            //warrior.Move( );

    //            warrior.Attack();
    //        }
    //        Console.ReadLine();
    //    }

    //    public class Student : IHuman
    //    {

    //        public void Move()
    //        {
    //            Console.WriteLine("Got to University");
    //        }
    //    }

    class AdvancedNinja : Ninja IHuman, IWarrior
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

    //    public class Ninja : IHuman, IWarrior
    //    {
    //        private IWeapon weapon;

    //        public Ninja(IWeapon weapon)
    //        {
    //            this.weapon = weapon;
    //        }
    //        public void Move()
    //        {
    //            Console.WriteLine("Got to battle field");
    //        }

    //        public void Attack()
    //        {
    //            weapon.Strike();
    //        }
    //    }

    //    public interface IWeapon
    //    {
    //        void Strike();
    //    }
    //    public interface IHuman
    //    {
    //        void Move();
    //    }
    //    public interface IWarrior
    //    {
    //        void Attack();
    //    }

    //    public class Sword : IWeapon
    //    {
    //        public void Strike()
    //        {
    //            Console.WriteLine($"{nameof(Sword)} Hit");
    //        }
    //    }

    //    public class Nunjucks : IWeapon
    //    {
    //        public void Strike()
    //        {
    //            Console.WriteLine($"{nameof(Nunjucks)} Hit");
    //        }
    //    }
    //}
}
