using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleTriviant
{
    class Program
    {

        static int Score = 0; // aantal vragen goed
        static string Vraag = "Welk nummer heeft de auto van Verstappen?"; //vraag
        static string[] Antwoorden = { "36", "33", "47", "56" }; // array met multiplechoice
        static int JuisteAntwoord = 1; // index in array antwoorden van juiste antwoord

        static void Main(string[] args)
        {
            Console.WriteLine("Hallo welkom bij het spel Triviant");
            Console.WriteLine("Je krijgt een meerkeuze vraag");
            Console.WriteLine("Je ziet vier verschillende antwoorden");
            Console.WriteLine("Kies het goeie anwoord en je krijgt gelijk " +
                "het resultaat. Als je wilt beginnen, druk dan op Enter.");
            Console.ReadLine();
            showVraag(1);
        }
        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag " + Nr + ":");
            Console.WriteLine(Vraag);
            Console.WriteLine("");
        }
        static void showAntwoorden()
        {
            int teller = 0;
            foreach (string antwoord in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ". " + antwoord);
            }
            Console.WriteLine("");
            Console.WriteLine("Type jouw keuze : 1,2,3 of 4");
            showAntwoorden();

            int Antwoord = int.Parse(Console.ReadLine());
        }
        static int checkAntwoord(int Antw)
        {
            if (Antw == JuisteAntwoord + 1)
            {
                return 1;
            }
            else if (Antw > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
            switch (checkAntwoord(Antw))
            {
                case 1:
                    Console.WriteLine("Goed gedaan.");
                    Score++;
                    break;
                case 0:
                    Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + Antwoorden[JuisteAntwoord]);
                    break;
                case 99:
                    Console.WriteLine("Dit is geen geldige invoer.");
                    break;
            }
        }    
   }
}    
        