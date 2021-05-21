using System;

namespace Task1
{
    internal class Program
    {
        class Car
        {
            public string TypeOfCar { get; set; }
            public string Model { get; set; }
 
            public string Color { get; set; }
            public int CreatedYear { get; set; }
            public int MilesDriven { get; set; }
        }
        public static void Main(string[] args)
        { /*
Skapa en klass som representerar en bil. Förutom märke och modell så lägger du själv till ytterligare 3 egenskaper som beskriver en bil.
Skriv sedan ett kort exempel där du skapar en ny bil, fyller objektet med data och sedan skriver ut datan. */
            Car car = new Car();
            
            Console.Write("What type of car do you have: ");
            car.TypeOfCar = Console.ReadLine();
            
            Console.Write("What type of car model do you have: ");
            car.Model = Console.ReadLine();
            
            Console.Write("What type of color on your car do you have: ");
            car.Color = Console.ReadLine();
            
            Console.Write("What year was your car created: ");
            car.CreatedYear = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How many Swedish miles has your car driven: ");
            car.MilesDriven = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n\nCar: " + car.TypeOfCar + "\nCar model: " + car.Model + "\nColor of car: " + car.Color + "\nCar created: " + car.CreatedYear +"\nCar: " + car.MilesDriven + "\nSwedish mile driven: " + car.MilesDriven);

        }
    }
}