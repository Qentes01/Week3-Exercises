using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestatud tähte
            //prgramm kontrollib kas sisestatud täht on
            //täishäälik voi kaashäälik
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälikuid"
            //kasutame switch´i

            //"mingi sõna" - string
            // "a"-character ehk char

            Console.WriteLine("Sisestage täht");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;
                default:
                    Console.WriteLine("Kaashäälik");
                    break;

                




            }
            

            
        }
    }
}
