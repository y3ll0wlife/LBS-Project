/*
Skapa ett program som demonstrerar användningen av klasser. Skapa en klass som heter Bilar och 
innehåller 3 egenskaper (kostnad - decimaltal, modell - string, miltal - heltal).
Skapa sedan tre bilar med olika egenskaper.
*/

using System;

namespace Uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();

            // Car 1 
            c1.price = 50.0;
            c1.model = "Teswa";
            c1.miles = 1337;

            // Car 2 
            c2.price = 25123.123;
            c2.model = "Fewwawi";
            c2.miles = 123123;


            // Car 3 
            c3.price = 26546245.515;
            c3.model = "Wambowghinyi";
            c3.miles = 52423542;

        }
    }

    public class Car
    {
        public double price;
        public string model;
        public int miles;

    }
}

