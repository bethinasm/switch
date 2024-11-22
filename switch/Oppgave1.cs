using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchOppgave
{
    internal class Oppgave1
    {
        /*
            Ha en variabel med datatypen int og gi den en value med et 
            tall mellom 1 og 7. 
            Bruk en switch for å finne ut hvilken dag i 
            uken det tallet er, og print ut dagen med Console.WriteLine();
            
            Eksempel: 
            1 er mandag, 2 er tirsdag, osv. 
         */

        public void Run()
        {
            Console.WriteLine("OPPGAVE 1");

            Random random = new Random();
            int randomNr = random.Next(0,8);
            Console.WriteLine($"Random number is {randomNr}");
            PrintDay(randomNr);
        }

        private void PrintDay(int randomNr)
        {
            switch (randomNr)
            {
                case 1:
                    Console.WriteLine("1 is Monday, the first day of the week.");
                    break;
                case 2:
                    Console.WriteLine("2 is Tuesday, the second day of the week.");
                    break;
                case 3:
                    Console.WriteLine("3 is Wednesday, the third day of the week.");
                    break;
                case 4:
                    Console.WriteLine("4 is Thursday, the fourth day of the week.");
                    break;
                case 5:
                    Console.WriteLine("5 is Friday, the fifth day of the week.");
                    break;
                case 6:
                    Console.WriteLine("6 is Saturday, the sixth day of the week.");
                    break;
                case 7:
                    Console.WriteLine("7 is Sunday, the seventh and last day of the week.");
                    break;
                default:
                    Console.WriteLine("Not a valid number.");
                    break;
            }
        }
    }
}