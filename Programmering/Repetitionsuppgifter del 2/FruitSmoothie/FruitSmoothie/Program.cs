using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace FruitSmoothie
{
    class Program
    {
        class Smoothie
        {
            public string[] Ingdients;
            static Dictionary<string, string> prices = new Dictionary<string, string>()
            {
                { "Strawberries", "$1.50" },
                { "Banana", "$0.50" },
                { "Mango", "$2.50" },
                { "Blueberries", "$1.00" },
                { "Raspberries", "$1.00" },
                { "Apple", "$1.75" },
                { "Pineapple", "$3.50" }
            };
            public double GetCost()
            {
                double total = 0;
                foreach (string ingrident in Ingdients)
                {
                    string productPrice = prices.FirstOrDefault(x => x.Key == ingrident).Value;
                    string strPrice = Regex.Replace(productPrice, "[^.0-9]", "");
                    double price = double.Parse(strPrice, System.Globalization.CultureInfo.InvariantCulture);
                    total += price;
                }
                
                return total;
            }
            public double GetPrice()
            {
                double price = GetCost();
                return Math.Round(price + price * 1.5, 2);
            }

            public string GetName()
            {
                string name = "";

                if (Ingdients.Length == 1) name = $"{Ingdients[0]} Smoothie";
                else
                {
                    foreach (string ingrident in Ingdients) name += $"{ingrident} ";
                    name += "Fusion";
                }
                return name;
            }

            public Smoothie(string[] ingredients)
            {
                Ingdients = ingredients;
            }
        }
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[]{ "Banana" });
            Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries"});
            Smoothie s3 = new Smoothie(new string[] { "Strawberries", "Banana", "Mango", "Blueberries", "Raspberries", "Apple", "Pineapple" });

            Console.WriteLine($"${s1.GetCost()}");
            Console.WriteLine($"${s1.GetPrice()}");
            Console.WriteLine(s1.GetName());
            Console.WriteLine();

            Console.WriteLine($"${s2.GetCost()}");
            Console.WriteLine($"${s2.GetPrice()}");
            Console.WriteLine(s2.GetName());
            Console.WriteLine();

            Console.WriteLine($"${s3.GetCost()}");
            Console.WriteLine($"${s3.GetPrice()}");
            Console.WriteLine(s3.GetName());

            Console.ReadKey();
        }
    }
}
