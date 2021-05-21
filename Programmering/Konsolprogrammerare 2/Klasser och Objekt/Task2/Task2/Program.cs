using System;

namespace Task2
{
    internal class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            public string FullName { get { return FirstName + " " + LastName; } }

        }
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("First name: ");
            person.FirstName = Console.ReadLine();
            
            Console.Write("Last name: ");
            person.LastName = Console.ReadLine();
            
            Console.WriteLine("\n\n" + person.FullName);
        }
    }
}