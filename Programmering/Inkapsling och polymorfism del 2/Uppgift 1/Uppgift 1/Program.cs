using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Monster
    {
        public int liv;
        public string namn;
        public int skada;
    }

    class Alien : Monster
    {
        public string hemplanet;
        public int ålder;
    }

    class Zombie: Monster
    {
        public bool gillarHjärnor;
        public int antaletÄtna;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alien alien = new Alien() { liv = 100, skada = 200, namn = "Bob", hemplanet= "Leseinov", ålder=810 };
            Zombie zombie = new Zombie() { liv = 200, skada = 40, namn = "Alice", gillarHjärnor=true, antaletÄtna=103 };
        }
    }
}
