/*
Skapa basklassen Djur. Klassen ska ha tre fält, en metod och 2 subklasser:
- int antalBen
- bool ärRovdjur
- string ras
- metoden HämtaFakta() som skriver ut ovanstående information om objektet.
- 2 subklasser (tex katt eller åsna)
Instansiera sedan 1 objekt av respektive subklass och kalla på metoden HämtaFakta():
 */

using System;

namespace Uppgift_1
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

    }

    class Hund : Djur
    {

    }
    class Ko : Djur
    {

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Hund alice = new Hund() { antalBen = 4, ras = "Yorkshireterrier", ärRovdjur = false };
            alice.HämtaFakta();

            Console.ReadKey();
        }
    }
}
