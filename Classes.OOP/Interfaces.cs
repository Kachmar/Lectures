using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.OOP
{
    interface IContract
    {
        int FirstName { get; set; }
        string GetText();
    }

    internal class Sword 
    {
        public void Strike()
        {
            Console.WriteLine($"{nameof(Sword)} Hit");
        }
    }

    internal class Ninja
    {
        Sword weapon = new Sword();

        public void Attack()
        {
            weapon.Strike();
        }

        public void Move()
        {
            Console.WriteLine("Go to battle field");
        }
    }

    class Program
    {
        public static void Main()
        {
            Ninja ninjaWithSword = new Ninja();
            ninjaWithSword.Move();
            ninjaWithSword.Attack();

            // now I want my ninja to use nunjucks...use the interface IWeapon

            //I Want to have a new type of warrior: trooper

            //I want to form an army from my warriors, so lets add them to one collection.
            
            // Let the army move and attack

            //Now I wan't ninjas to have multiple weapons, and use them all during attack

            
            //now I want a human...create an IHuman that can move interface

            //Now I want to have a collection of all people: ninjas and humans.
            
            // We lost the battle...retreat
            Console.ReadLine();
        }
    }

    //interface IWarrior : IHuman
    //{
    //    void Attack();
    //}

    //interface IHuman
    //{
    //    void Move();
    //}

    //interface IWeapon
    //{
    //    void Strike();
    //}

    //internal class Human : IHuman
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Go to work");
    //    }
    //}

    //internal class Nunjucks : IWeapon
    //{
    //    public void Strike()
    //    {
    //        Console.WriteLine($"{nameof(Nunjucks) } Hit");
    //    }
    //}

    //class Trooper : IWarrior
    //{

    //    public void Move()
    //    {
    //        Console.WriteLine($"{nameof(Trooper)} goes to the battle field.");
    //    }

    //    public void Attack()
    //    {
    //        Console.WriteLine($"{nameof(Trooper)} punches.");
    //    }
    //}
    

    //class AdvancedNinja : Ninja IHuman, IWarrior
    //{
    //    private IWeapon[] weapons;

    //    public AdvancedNinja(IWeapon[] weapons)
    //    {
    //        this.weapons = weapons;
    //    }
    //    public void Move()
    //    {
    //        Console.WriteLine("Got to battle field");
    //    }

    //    public void Attack()
    //    {
    //        foreach (var weapon in this.weapons)
    //        {
    //            weapon.Strike();
    //        }
    //    }
    //}
   
}
