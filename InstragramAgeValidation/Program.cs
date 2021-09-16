using System;

namespace InstragramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib,kas kasutaja onvanem kui 13 või 13 aasta vana
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib instagrammi kasutada
            //kui kasutaja on noorem,kui 13 siis ta liiga noor

            Console.WriteLine("Sisestage oma sünniaasta");
            int age = Convert.ToInt32(Console.ReadLine());
            int Birth = 2021 - age;

            if(Birth >= 13)
            {
                Console.WriteLine("Tere tulemast");
            }
            else 
            {
                Console.WriteLine("Oled liiga noor");
            }

            
        }
    }
}
