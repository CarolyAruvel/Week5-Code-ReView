using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 vüi noorem kui 13 aastat vana
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võõib Instagrami kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor

            Console.WriteLine("Sisestada sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 13)
            {
                Console.WriteLine("Võid Instagrami kasutada.");

            }
            else
            {
                Console.WriteLine("Oled liiga noor.");
            }
        }
    }
}
    

