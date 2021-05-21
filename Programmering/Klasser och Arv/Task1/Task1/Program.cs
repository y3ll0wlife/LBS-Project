using System;

namespace Task1
{
    class Hus
    {
        public int antalRum;
        public double area;
        public string adress;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Hus hus1 = new Hus();
            hus1.antalRum = 4;
            hus1.area = 120;
            hus1.adress = "Grenadjärvägen 12";

            Hus hus2 = new Hus();
            hus2.antalRum = 1;
            hus2.area = 50;
            hus2.adress = "Min Adress 42";
        }
    }
}
