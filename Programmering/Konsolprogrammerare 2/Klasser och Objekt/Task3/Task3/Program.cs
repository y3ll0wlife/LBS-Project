using System;

namespace Task3
{
    internal class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime  Age { get; set; }
            public bool IsOver18 { get; set; }
            
            public string FullName { get { return FirstName + " " + LastName + "\nBorn: " + Age + "\nIs over 18: " + IsOver18; } }

        }
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("First name: ");
            person.FirstName = Console.ReadLine();
            
            Console.Write("Last name: ");
            person.LastName = Console.ReadLine();
            
            Console.Write("When were you born (Year-Month-Day): ");
            person.Age = Convert.ToDateTime(Console.ReadLine());

            if (DateTime.Now.Year - person.Age.Year >= 18) person.IsOver18 = true;
            else person.IsOver18 = false;
            Console.WriteLine("\n\n" + person.FullName);
        }
    }
}