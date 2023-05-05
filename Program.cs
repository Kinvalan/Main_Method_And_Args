/*
Oppgave 1: 

Send inn 5 argumenter til mainmetoden og print de ut til konsollen

Hint: Console.WriteLine();

-----------------------------------------------

    Oppgave 2: 

Send inn et hvilket som helst antall argumenter til mainmetoden,

    og print ut et tall som sier noe om hvor mange argumenter du har sendt inn.

    Dersom du sender inn "hei på deg" skal tallet 3 printes til konsollen

    Koden skal fungere med et ulikt antall argumenter!
*/

namespace Main_Method_And_Args
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            foreach (var argument in args)
            {   
                Console.WriteLine(argument + " " + number++);
                
            }
        }
    }
}