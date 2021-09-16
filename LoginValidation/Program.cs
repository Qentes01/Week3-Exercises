using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsub kasutaja sisestada kasutaja tunnus ja parool
            //programm kontrollib sisestatud andmeid 
            //kui sisetatud kasutaja tunnus on "admin" ja
            // sisestatud parool on "admin1234"
            //siis programm kuvab "tere tulemast!"
            //muul juhul programm kuvab "vale kasutaja tunnus või parool.Proovi uuesti";
            // options 1

            Console.WriteLine("Sisestage kasutaja tunnus ja parool");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string password = Console.ReadLine();
            /*
             if (username == "admin" && password == "admin1234")
            {
                Console.WriteLine("tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale kasutaja tunnus või parool.Proovi uuesti");
            }
            */
            if(username != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale parool.Proovige uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }

        }
    }
}
