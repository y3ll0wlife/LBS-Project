/*
Bygg vidare på uppgift 2. Skapa en metod för respektive subklass.
- Metoden ska också heta Läte() men ska ha nyckelordet override. 
Varje metod i subklasserna ska vara unik. 
(glöm inte säga att “bas”-metoden i huvudklassen ska vara virtual
 */

using System;

namespace Uppgift_3
{
    class Djur
    {
        public int antalBen;
        public bool ärRovdjur;
        public string ras;

        public void HämtaFakta()
        {
            Console.WriteLine($"{ras}\n{ärRovdjur}\n{antalBen}");
        }


        public virtual void Läte()
        {
            Console.WriteLine("Yooooooooo");
        }

        public Djur(int antalBen, string ras)
        {
            this.antalBen = antalBen;
            this.ras = ras;
        }
    }

    class Hund : Djur
    {
        public Hund(int antalBen, string ras) : base(antalBen, ras) { }

        public override void Läte()
        {
            Console.WriteLine("Woof Woof Woof");
        }
    }
    class Ko : Djur
    {
        public Ko(int antalBen, string ras) : base(antalBen, ras) { }

        public override void Läte()
        {
            Console.WriteLine("Muuuuuu");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hund alice = new Hund(4, "Yorkshireterrier");
            alice.HämtaFakta();
            alice.Läte();

            Console.WriteLine("-----------------");

            Ko bob = new Ko(4, "Japanese Black-kor");
            bob.HämtaFakta();
            bob.Läte();

            Console.ReadKey();
        }
    }
}
