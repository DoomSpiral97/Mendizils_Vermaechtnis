using System;

namespace Konsolengame
{
    class Program
    {

        static void Main(string[] args)
        {
            Spieler spieler;
            bool spielLaeuft = true;
            Console.WriteLine("1) Neues Spiel");
            Console.WriteLine("2) Spiel laden");
            string? choice = Console.ReadLine();

            if (choice == "2")
            {
                var geladenerSpieler = Speicherstand.LadeSpieler();
                if (geladenerSpieler != null)
                {
                    spieler = geladenerSpieler;
                    Console.WriteLine($"Willkommen zurück, {spieler.Name}!");
                }
                else
                {
                    Console.WriteLine("Kein Speicherstand gefunden. Neues Spiel wird gestartet.");
                    spieler = Hilfsmethoden.Charakterwahl();
                }
            }
            else
            {
                spieler = Hilfsmethoden.Charakterwahl();
            }

            while (spielLaeuft)
            {

                string? eingabe = Hilfsmethoden.Questboard();

                switch (eingabe)
                {
                    case "1":
                    {
                        StadtErkunden.Start(spieler);
                        break;
                    }

                    case "2":
                    {
                        Quests.MagisterQuest(spieler);
                        break;
                    }
                    case "3":
                    {
                        Quests.RuinenQuest(spieler);
                        break;
                    }
                    case "5":
                    {
                        Quests.DrachenQuest(spieler);
                        break;
                    }
                    case "4":
                        Quests.WaldQuest(spieler);
                        break;
                    case "i":
                    {
                        spieler.InventarAnzeigen();
                        break;
                    }
                    case "0":
                        Console.WriteLine("Bis zum nächsten Mal Noob");
                        spielLaeuft = false;
                        break;
                    case "s":
                        Console.WriteLine(
                            "Du denkst über deine Erlebten Abenteuer nach und schreibst sie in dein Tagebuch");
                        Speicherstand.SpeichereSpieler(spieler);
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        break;
                }
            }
        }
    }
}
