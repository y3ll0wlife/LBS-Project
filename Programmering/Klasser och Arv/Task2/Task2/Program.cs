using System;

namespace Task2
{
    class Apa
    {
        public bool gillarBananer;
        public int antalBananer;
        public string färg;
        public int ålder;

        public void ÄtaBanan()
        {
            if (antalBananer > 0)
            {
                antalBananer--;
                Console.WriteLine($"NomNomNom! {antalBananer} bananer kvar.");
            }
            else Console.WriteLine("Det finns inga bananer kvar :(");
        }

        public Apa(bool gillarBananer, int antalBananer, string färg, int ålder)
        {
            this.gillarBananer = gillarBananer;
            this.antalBananer = antalBananer;
            this.färg = färg;
            this.ålder = ålder;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Apa Alice = new Apa(true, 5, "brun", 7);
            for (int i = 0; i < 8; i++)
            {
                Alice.ÄtaBanan();
            }
        }
    }
}
