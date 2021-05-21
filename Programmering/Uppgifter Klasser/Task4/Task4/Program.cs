/*
* Bygg vidare på övning 3. 
* Lägg till egenskaper för höjd och vikt. Använd lämplig datatyp. 
* Lägg till ytterligare en beräknad egenskap kallad BMI. 
* Använd formeln för BMI (Body Mass Index), BMI = vikten / (längden * längden).
*/

using System;

namespace Task4
{
    class Program
    {
        class User
        {
            public string FirstName { get; set; }
            public string NickName { get; set; }
            public string LastName { get; set; }
            public DateTime DateBorn { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }

            public bool IsUserMature { get; set; }
            public double BMI { get; set; }
           

            public void WriteUser()
            {
                Console.WriteLine($"{FirstName} \"{NickName}\" {LastName}");
                Console.WriteLine($"Born at {DateBorn.ToString("F")}");

                if (IsUserMature) Console.WriteLine("User is mature");
                else Console.WriteLine("User is not mature");

                Console.WriteLine($"You BMI is {BMI}");
            }

            public void CalculateBMI()
            {
                Height = Height / 100; // convert from cm to m
                BMI = Weight / Math.Pow(Height, 2); // calcuate and set the value
            }

            public User(string firstName, string nickName, string lastName, DateTime born, double height, double weight)
            {
                FirstName = firstName;
                NickName = nickName;
                LastName = lastName;
                DateBorn = born;
                Height = height;
                Weight = weight;

                IsUserMature = (DateTime.Now.Year - born.Year) >= 18;
                CalculateBMI();
            }
        }
        static void Main(string[] args)
        {
            User user = new User("Stig", "The POW", "Nilsson", new DateTime(2015, 12, 25), 200, 80);
            user.WriteUser();
            Console.ReadKey();
        }
    }
}
