/*
* Skapa en klass som innehåller fält för förnamn, Smeknamn och efternamn (Strängar). 
* Skapa också ett fält kan spara förnamn + smeknamn+ efternamn. 
* Avsluta med att skriva ihop ett exempel där du använder klassen och visar att den fungerar.
* EX: Stig “The POW” Nilsson
 */

using System;

namespace Task2
{
    class Program
    {
        class User
        {
            public string FirstName { get; set; }
            public string NickName { get; set; }
            public string LastName { get; set; }

            public void WriteUser()
            {
                Console.WriteLine($"{FirstName} \"{NickName}\" {LastName}");
            }

            public User(string firstName, string nickName, string lastName)
            {
                FirstName = firstName;
                NickName = nickName;
                LastName = lastName;
            }
        }
        static void Main(string[] args)
        {
            User user = new User("Stig", "The POW", "Nilsson");
            user.WriteUser();
            Console.ReadKey();
        }
    }
}
