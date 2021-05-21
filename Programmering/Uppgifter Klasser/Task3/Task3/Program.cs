/*
* Bygg vidare på övning 2. Lägg till en egenskap av typen DateTime som beskriver födelsedatum. 
* DateTime födelsedag = new DateTime(2015, 12, 25);   
* Lägg till en ny beräknad egenskap av typen bool som returnerar true om personen är myndig (minst 18 år gammal).
*/

using System;

namespace Task3
{
    class Program
    {
        class User
        {
            public string FirstName { get; set; }
            public string NickName { get; set; }
            public string LastName { get; set; }
            public DateTime DateBorn { get; set; }
            public bool IsUserMature { get; set; }

            public void WriteUser()
            {
                Console.WriteLine($"{FirstName} \"{NickName}\" {LastName}");
                Console.WriteLine($"Born at {DateBorn.ToString("F")}");

                if (IsUserMature) Console.WriteLine("User is mature");
                else Console.WriteLine("User is not mature");
            }

            public User(string firstName, string nickName, string lastName, DateTime born)
            {
                FirstName = firstName;
                NickName = nickName;
                LastName = lastName;
                DateBorn = born;

                IsUserMature = (DateTime.Now.Year - born.Year) >= 18;
               
            }
        }
        static void Main(string[] args)
        {
            User user = new User("Stig", "The POW", "Nilsson", new DateTime(2015, 12, 25));
            user.WriteUser();
            Console.ReadKey();
        }
    }
}
