using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4
{
    class Monster
    {
        public double liv;
        public string namn;
        public double skada;
        public int level;

        public void StartAttack(Monster monster, ref Spelare spelare)
        {
            Random rnd = new Random();
            int attack = rnd.Next(0, 2);

            if (attack == 0) Attack(monster, ref spelare);
            else if (attack == 1) SuperAttack(monster, ref spelare);
        }

        public void Attack(Monster monster, ref Spelare spelare)
        {
            spelare.liv -= monster.skada;
            Console.WriteLine($"[Monster] {monster.namn} attackerade ({monster.skada} skada) {spelare.namn} som nu har {spelare.liv} liv kvar!");
            
            if (spelare.liv <= 0) Console.WriteLine($"[Spelare] {spelare.namn} är död!");
        }

        public void SuperAttack(Monster monster, ref Spelare spelare)
        {
            Random rnd = new Random();

            double damage = Math.Round(monster.skada + monster.skada * rnd.NextDouble());
            spelare.liv -= damage;
            Console.WriteLine($"[Monster] {monster.namn} super attackerade ({damage} skada) {spelare.namn} som nu har {spelare.liv} liv kvar!");

            if (spelare.liv <= 0) Console.WriteLine($"[Spelare] {spelare.namn} är död!");
        }
    }

    class Spelare
    {
        public double liv;
        public string namn;
        public double skada;
        public int level;
        public int dogeChance;

        public void Attack(ref Spelare spelare, Monster monster)
        {
            monster.liv -= spelare.skada;
            Console.WriteLine($"[Spelare] {spelare.namn} attackerade ({spelare.skada} skada) {monster.namn} som nu har {monster.liv} liv kvar!");

            if (monster.liv <= 0) Console.WriteLine($"[Monster] {monster.namn} är död!");
           
        }

        public bool Skydda(Spelare spelare, Monster monster)
        {
            float x = spelare.level / monster.level;
            Random rnd = new Random();
            float a = (float)(10.0 * Math.Sqrt(rnd.Next(1, 16)));

            return (a / x * Math.Sqrt(rnd.Next(1, 16)) > dogeChance);
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
            Alien alien = new Alien() { liv = 100, skada = 200, namn = "Alien", level=500, hemplanet = "Leseinov", ålder = 810 };
            Zombie zombie = new Zombie() { liv = 200, skada = 40, namn = "Zombie", level=200, gillarHjärnor = true, antaletÄtna = 103 };

            Spelare spelare = new Spelare() { liv = 500, skada = 80, namn = "Spelare", level=300, dogeChance=60 };

            while(alien.liv > 0 || zombie.liv > 0)
            {
                Random rnd = new Random();

                // player part
                int spelareAttack = rnd.Next(0, 0);
                Monster target = alien;
                if (alien.liv <= 0) target = zombie;
                if (spelareAttack == 0) spelare.Attack(ref spelare, target);


                // monster part
                if (alien.liv > 0)
                {
                    if (spelare.Skydda(spelare, alien)) alien.StartAttack(alien, ref spelare);
                    else Console.WriteLine($"[Spelare] Skyddade sig och {alien.namn} missade");
                }
                if (zombie.liv > 0)
                {
                    if (spelare.Skydda(spelare, zombie)) zombie.StartAttack(zombie, ref spelare);
                    else Console.WriteLine($"[Spelare] Skyddade sig och {zombie.namn} missade");
                }

                if (alien.liv <= 0 && zombie.liv <= 0) Console.WriteLine($"\n\n{spelare.namn} vann!");
                else if(spelare.liv <= 0)
                {
                    Console.WriteLine($"\n\nMonsterna vann :(");
                    break;
                }
            }

          
            Console.ReadKey();
        }
    }
}
