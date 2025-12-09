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
                Hilfsmethoden.SpielbeginnLore();
                spieler.ItemHinzufügen(Item.Hilferuf);
                Hilfsmethoden.Weiter();
                Console.Clear();
            }

            while (spielLaeuft)
            {
                
                string? eingabe = Hilfsmethoden.Questboard();

                switch (eingabe)
                {
                    case "1":
                    {   Console.Clear();
                        StadtErkunden.Start(spieler);
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                    }

                    case "2":
                    {
                        Quests.MagisterQuest(spieler);
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                    }
                    case "3":
                    {
                        Quests.RuinenQuest(spieler);
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                    }
                    case "5":
                    {
                        Quests.DrachenQuest(spieler);
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                    }
                    case "4":
                        Quests.WaldQuest(spieler);
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                    case "i":
                    {
                        spieler.InventarAnzeigen();
                        Console.Clear();
                        break;
                    }
                    case "0":
                        Console.WriteLine("Bis zum nächsten Mal Noob");
                        spielLaeuft = false;
                        break;
                    case "s":
                        Console.WriteLine("Du denkst über deine Erlebten Abenteuer nach und schreibst sie in dein Tagebuch");
                        Speicherstand.SpeichereSpieler(spieler);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe.");
                        Hilfsmethoden.Weiter();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
