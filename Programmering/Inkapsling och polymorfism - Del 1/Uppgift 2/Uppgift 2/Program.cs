/*
Utveckla uppgift 1 vidare. Lägg till en till metod i basklassen och skapa en konstruktor.
- Skapa metoden Läte() som skriver ut “Muuuu”
- Skapa en konstruktor som tilldelar värden till antalBen och ras (men inte ärRovdjur)
 */

using System;

namespace Uppgift_2
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


        public void Läte()
        {
            Console.WriteLine("Muuuu");
        }

        public Djur(int antalBen, string ras)
        {
            this.antalBen = antalBen;
            this.ras = ras;
        }
    }

    class Hund : Djur
    {
        public Hund(int antalBen, string ras) : base(antalBen, ras){}
    }
    class Ko : Djur
    {
        public Ko(int antalBen, string ras) : base(antalBen, ras){}
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
