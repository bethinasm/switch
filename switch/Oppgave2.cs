using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchOppgave
{
    internal class Oppgave2
{
        /*  Ta utgangspunkt fra oppgave 1, men istedenfor
            å bruke en int med en fastsatt value, bruker du Console.ReadLine() 
            for at man kan skrive inn et tall i konsollen. Hvis man ikke 
            får inn et tall, skal switch-en kjøre programmet på nytt. 
        */
        public void Run()
        {
        Console.WriteLine("OPPGAVE 1");
        Console.WriteLine("What day is it? Write a number between 1 - 7");
        string userInput = Console.ReadLine();
        int dayNumber = Convert.ToInt32(userInput);
        PrintDay(dayNumber);
        }

        private void PrintDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("You pressed 1. 1 is Monday, the first day of the week.");
                    break;
                case 2:
                    Console.WriteLine("You pressed 2. 2 is Tuesday, the second day of the week.");
                    break;
                case 3:
                    Console.WriteLine("You pressed 3. 3 is Wednesday, the third day of the week.");
                    break;
                case 4:
                    Console.WriteLine("You pressed 4. 4 is Thursday, the fourth day of the week.");
                    break;
                case 5:
                    Console.WriteLine("You pressed 5. 5 is Friday, the fifth day of the week.");
                    break;
                case 6:
                    Console.WriteLine("You pressed 6. 6 is Saturday, the sixth day of the week.");
                    break;
                case 7:
                    Console.WriteLine("You pressed 7. 7 is Sunday, the seventh and last day of the week.");
                    break;
                default:
                    Console.WriteLine("Not a valid number.");
                    Run();
                    break;
            }
        }
    }
}
