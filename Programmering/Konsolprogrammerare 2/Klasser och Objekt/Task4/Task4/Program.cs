using System;

namespace Task4
{
    internal class Program
    {
        class Person
        {
            public int Height { get; set; }
            public int Weight { get; set; }
            
            public double BMI { get { return (Convert.ToDouble(Weight)/(Convert.ToDouble(Height)*Convert.ToDouble(Height))) * 10000; } }
        }
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("What is your height in CM: ");
            person.Height = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your weight in kg: ");
            person.Weight = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("BMI: " + person.BMI);
        }
    }
}