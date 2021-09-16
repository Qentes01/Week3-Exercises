using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib sisestada Pin koodi
            //programm võrdleb sisestatud Pin-koodi arvuga 1234
            //kui sisestatud pin kood on 1234
            // programm kuvab konsoolis "tere tulemast!"
            // kui sisestatud Pin on vale,programm kuvab konsoolis
            //"vale PIN.Proovi uuesti"

            Console.WriteLine("Sisestage oma Pin-Kood");
            
              int pin = Convert.ToInt32(Console.ReadLine());
            /*
             * if(pin == 1234)
            {
               Console.WriteLine("Tere tulemast");
            }

            else
            {
               Console.WriteLine("Pin-Kood on vale");   
            }
            */

            if(pin != 1234)
            {
                Console.WriteLine("Vale Pin.Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Õige Pin");
            }
            
        }
    }
}
