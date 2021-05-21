using System;

namespace Task3
{
    class Bil
    {
        public int antalHjul;
        public string färg;
        public int antalDörrar;
        public string märke;
        public double milttal;

        public void Tut()
        {
            Console.WriteLine("TUUUUUT!");
        }
    }

    class Polisbil : Bil
    {
        public string catchPhrase;
        public int antalTjuvarFångade;
    }

    class Ambulans : Bil
    {
        public string förare;
        public string patient;
    }

    class Budget : Bil
    {
        public int pris;
        public int ålder;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Polisbil alice = new Polisbil()
            {
                antalDörrar = 5,
                antalHjul = 4,
                färg = "Blå",
                catchPhrase = "The lawww",
                antalTjuvarFångade = 135,
                milttal = 7,
                märke = "Volvo"
            };

            alice.Tut();
            Console.WriteLine($"Catch Phrase: {alice.catchPhrase}\nAntal Fångade Tjuvar: {alice.antalTjuvarFångade}");
            Console.WriteLine("------------------------");

            Ambulans bambulans = new Ambulans()
            {
                antalDörrar = 3,
                antalHjul = 4,
                färg = "Blå",
                förare = "Bob",
                patient = "Alice",
                milttal = 7,
                märke = "BMW"
            };

            bambulans.Tut();
            Console.WriteLine($"Förare: {bambulans.förare}\nPatient: {bambulans.patient}");
            Console.WriteLine("------------------------");

            Budget billig = new Budget()
            {
                antalDörrar = 2,
                antalHjul = 3,
                färg = "Blå",
                pris = 6,
                ålder = 59,
                milttal = 10000,
                märke = "Okänd"
            };

            billig.Tut();
            Console.WriteLine($"Pris: {billig.pris}\nÅlder: {billig.ålder}");

        }
    }
}
