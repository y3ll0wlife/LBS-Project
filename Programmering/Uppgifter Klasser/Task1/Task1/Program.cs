/*
* Skapa en progam med en klass som representerar en bil. 
* Förutom Märke, miltal och pris så skapar du ytterligare 3 “egenskaper” (fält) som beskriver en bil.
* Skriv sedan ett kort exempel där du skapar en ny bil, fyller objektet med data och sedan skriver ut datan i konsolen
*/
using System;

namespace Task1
{
    class Program
    {
        class Car
        {
            public string Brand { get; set; }
            public int Miles { get; set; }
            public int Price { get; set; }

            public int Doors { get; set; }
            public string FuelSource { get; set; }
            public int YearMade { get; set; }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Miles = 100;
            car.Price = 1000;
            car.Doors = 5;
            car.FuelSource = "Fire";
            car.YearMade = 2019;

            Console.WriteLine($"Brand: {car.Brand}\nMiles: {car.Miles}\nPrice: {car.Price}kr\nDoors: {car.Doors}\nFuel Source: {car.FuelSource}\nYear Made: {car.YearMade}");
            Console.ReadKey();
        }
    }
}
