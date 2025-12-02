namespace Konsolengame;

public abstract class Encounter
{
    public string Name { get; protected set; }

    public abstract void ShowIntro();

    // gibt true zurück, wenn Encounter erfolgreich, sonst false
    public bool StartEncounter(Spieler spieler, Charakter gegner)
    {
        ShowIntro();

        bool erfolgreich = false;
        bool encounterBeendet = false;

        while (!encounterBeendet)
        {
            Console.WriteLine();
            Console.WriteLine("Wie möchtest du vorgehen?");
            Console.WriteLine("1) Kämpfen");
            Console.WriteLine("2) Überreden");
            Console.WriteLine("3) Schleichen");
            Console.Write("Deine Wahl: ");

            string? eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    erfolgreich = Fight(spieler, gegner);
                    encounterBeendet = true;
                    break;
                case "2":
                    erfolgreich = TryPersuade(spieler, gegner);
                    encounterBeendet = true;
                    break;
                case "3":
                    erfolgreich = TrySneak(spieler, gegner);
                    encounterBeendet = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl, bitte 1 / 2 / 3 eingeben.");
                    break;
            }
        }

        if (erfolgreich)
        {
            ShowQuestSuccess();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Du bist in diesem Encounter gescheitert.");
        }

        return erfolgreich; // wichtig: Ergebnis nach außen geben
    }

    protected abstract bool Fight(Spieler spieler, Charakter gegner);
    protected abstract bool TryPersuade(Spieler spieler, Charakter gegner);
    protected abstract bool TrySneak(Spieler spieler, Charakter gegner);

    protected abstract void ShowQuestSuccess();
}