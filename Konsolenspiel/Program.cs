using System;

namespace Konsolengame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Spielläuft = true;
            Hilfsmethoden.Begrüßung();
            Spieler spieler = Hilfsmethoden.Charakterwahl();
            Console.WriteLine($"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n Charisma:{spieler.Charisma}");



            

                while (Spielläuft)
                {
                    Console.WriteLine("Du bist in der Stadt.");
                    Console.WriteLine("Wohin möchtest du gehen?");
                    Console.WriteLine("1) In den Wald");
                    Console.WriteLine("0) Spiel beenden");
                    string? eingabe = Console.ReadLine();

                    switch (eingabe)
                    {
                        case "1":
                        {
                            var encounter = new WaldEncounter();
                            bool waldGeschafft = encounter.StartEncounter(spieler, new Goblin());

                            if (waldGeschafft)
                            {
                                Console.WriteLine("Du hast den Wald geschafft.");
                                spieler.ItemHinzufügen(Items.Kristall);
                                spieler.ItemHinzufügen(Items.Schild);
                                // danach einfach zurück in die while-Schleife
                            }
                            else
                            {
                                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück....");
                                // ebenfalls keine Rückgabe, weiter im Hub
                            }
                            break;
                        }

                        case "0":
                            Console.WriteLine("Tschüss, Spiel wird beendet.");
                            Spielläuft = false;   // Schleife sauber beenden
                            break;

                        default:
                            Console.WriteLine("Ungültige Eingabe.");
                            // keine Rückgabe -> Schleife fragt erneut
                            break;
                    }
                }
        }
    }
}