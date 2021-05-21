using System;

namespace Task4
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

        public void FångaNyTjuv()
        {
            Console.WriteLine($"Fångade en ny tjuv :), du har nu fångat {antalTjuvarFångade} tjuvar totalt");
        }

        public void AnvändaSiren()
        {
            Console.WriteLine("WEEEWHOOOO!!!!");
        }
    }

    class Ambulans : Bil
    {
        public string förare;
        public string patient;


        public void BytPatient(string nyPatient)
        {
            Console.WriteLine($"Bytte patient från {patient} till {nyPatient}");
            patient = nyPatient;
        }
        public void AnvändaSiren()
        {
            Console.WriteLine("WEEEWHOOOO!!!!");
        }
    }

    class Budget : Bil
    {
        public int pris;
        public int ålder;

        public void FörsökSälja()
        {
            Console.WriteLine($"Vem vill köpa, vem vill köpa, fett billig bil, endast {pris} kr");
        }
        public void ÖkaÅlder()
        {
            Console.WriteLine("Det har gått ett till år och du har fortfrande inte sålt bilen :(");
            ålder++;
        }
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
            alice.AnvändaSiren();
            alice.FångaNyTjuv();
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
            bambulans.AnvändaSiren();
            bambulans.BytPatient("Erin");
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
            billig.ÖkaÅlder();
            billig.FörsökSälja();
            Console.WriteLine($"Pris: {billig.pris}\nÅlder: {billig.ålder}");

        }
    }
}
