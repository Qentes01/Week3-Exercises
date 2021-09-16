using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseasutuseks;
            //minimum matemaatikas 85 punkti;
            //minimum keemias 90 punkti;
            //minimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab,kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami tulemus:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma keemia eksami tulemus");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma bioloogia eksami tulemus");
            int biology = Convert.ToInt32(Console.ReadLine());

            if (math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Tubli! saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("Proovi järgmine aasta.");
            }

        }
    }
}
