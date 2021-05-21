using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3
{
    class Monster
    {
        public int liv;
        public string namn;
        public int skada;

        public void Attack(Monster monster, ref Spelare spelare)
        {
            spelare.liv -= monster.skada;
            if (spelare.liv <= 0) Console.WriteLine($"[Spelare] {spelare.namn} är död!");
            else Console.WriteLine($"[Monster] {monster.namn} attackerade {spelare.namn} som nu har {spelare.liv} i liv kvar!");
        }
    }

    class Spelare
    {
        public int liv;
        public string namn;
        public int skada;

        public void Attack(ref Spelare spelare, Monster monster)
        {
            monster.liv -= spelare.skada;
            if (monster.liv <= 0) Console.WriteLine($"[Monster] {monster.namn} är död!");
            else Console.WriteLine($"[Spelare] {spelare.namn} attackerade {monster.namn} som nu har {monster.liv} i liv kvar!");
        }
    }

    class Alien : Monster
    {
        public string hemplanet;
        public int ålder;
    }

    class Zombie : Monster
    {
        public bool gillarHjärnor;
        public int antaletÄtna;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alien alien = new Alien() { liv = 100, skada = 200, namn = "Bob", hemplanet = "Leseinov", ålder = 810 };
            Zombie zombie = new Zombie() { liv = 200, skada = 40, namn = "Alice", gillarHjärnor = true, antaletÄtna = 103 };

            Spelare spelare = new Spelare() { liv = 500, skada = 80, namn = "Eve" };

            for (int i = 0; i < 20; i++)
            {
                alien.Attack(alien, ref spelare);
                spelare.Attack(ref spelare, zombie);
            }

            Console.ReadKey();
        }
    }
}
