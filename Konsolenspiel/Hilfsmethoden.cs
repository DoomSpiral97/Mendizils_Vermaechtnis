namespace Konsolengame;

public class Hilfsmethoden
{
    public static void Begrüßung()
    {
        Console.WriteLine("Willkommen");
    }
    
    public static string Questboard()
    {
        
        Console.WriteLine("Du bist in der Stadt.");
        Console.WriteLine("Wohin möchtest du gehen?");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1) Erkunde die Stadt.");
        Console.WriteLine("2) Zur Kammer des Magisters");
        Console.WriteLine("3) Zu den Ruinen der Trauer");
        Console.WriteLine("4) In den düsteren Wald");
        Console.WriteLine("5) Zur Drachenhöhle");
        Console.WriteLine("I) Inventar anzeigen");
        Console.WriteLine("S) Ins Journal schreiben(SPEICHERN)");
        Console.WriteLine("0) Spiel beenden");
        Console.ResetColor();
        Console.Write("Deine Wahl: ");

        return Console.ReadLine().ToLower();
    }

    public static void HappyEnd()
    {
        Console.WriteLine("Du hast das Abenteuer gemeistert, mehr Quests gibt es mit dem Addon * Eisklauen von Sommerfell* für nur 12,99€");
    }

    public static Spieler Charakterwahl()
    {   
        Console.WriteLine("Gib deinen Namen ein:");
        string sname = Console.ReadLine();
        Console.WriteLine($"Willkommen in Grubenfurt {sname}. Wähle deine Klasse:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1. Krieger");
        Console.WriteLine("2. Barde");
        Console.WriteLine("3. Schurke");
        Console.ResetColor();
        

        while (true)
        {
            string input = Console.ReadLine();
            Spieler spieler;

            if (input == "1")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Krieger",
                    HP = 60,
                    MaximaleHP = 60,
                    Stärke = 18,
                    Charisma = 5,
                    Stealth = 3
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                Console.WriteLine("Drücke eine Taste zum Fortfahren");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("...");
                Console.ResetColor();
                return spieler;
            }
            else if (input == "2")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Barde",
                    HP = 55,
                    MaximaleHP = 55,
                    Stärke = 10,
                    Charisma = 20,
                    Stealth = 10
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                return spieler;
            }
            else if (input == "3")
            {
                spieler = new Spieler
                {
                    Name = sname,
                    Beschreibung = "Schurke",
                    HP = 57,
                    MaximaleHP = 57,
                    Stärke = 12,
                    Charisma = 10,
                    Stealth = 20
                };
                Console.WriteLine(
                    $"Du hast {spieler.Beschreibung} gewählt. Deine Stats sind:\n" +
                    $"Charisma: {spieler.Charisma}, Stärke: {spieler.Stärke}, Stealth: {spieler.Stealth}");
                Console.WriteLine("Introtext dass die Start vorstellt und Gerüchte anhören vorschlägt als Startpunkt...");
                return spieler;
            }
            else
            {
                Console.WriteLine("Bitte nur Zahlen 1, 2 oder 3 eingeben:");
            }
        }
    }
}