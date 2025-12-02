// WaldEncounter.cs
using Konsolengame;

public class WaldEncounter : Encounter
{
    private readonly Random _random = new Random();

    // Konkreter Gegner für diesen Encounter
    private Goblin goblin = new Goblin
    {
        Stärke = 22,
        Beschreibung = "Ein fieser Goblin",
        Charisma = 0,
        HP = 10,
        MaximaleHP = 10,
        Stealth = 2,
        Name = "Groff der Brecher",
        Wahrnehmung = 2,
    };

    public WaldEncounter()
    {
        Name = "Düsterer Wald";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst einen düsteren Wald. Zwischen den Bäumen raschelt etwas...");
    }

    // Kampf: wir benutzen einfach das Feld 'goblin' und ignorieren den Parameter
    protected override bool Fight(Spieler spieler, Charakter gegner)
    {
        Goblin goblin = this.goblin;

        Console.WriteLine();
        Console.WriteLine($"Ein {goblin.Name} springt aus dem Gebüsch!");

        while (spieler.HP > 0 && goblin.HP > 0)
        {
            int schadenSpieler = spieler.Stärke;
            goblin.HP -= schadenSpieler;
            Console.WriteLine($"Du triffst den {goblin.Name} für {schadenSpieler} Schaden. Gegner HP: {goblin.HP}");

            if (goblin.HP <= 0)
            {
                Console.WriteLine($"Der {goblin.Name} geht zu Boden!");
                return true;
            }

            int schadenGegner = goblin.Stärke;
            spieler.HP -= schadenGegner;
            Console.WriteLine($"{goblin.Name} trifft dich für {schadenGegner} Schaden. Deine HP: {spieler.HP}");

            if (spieler.HP <= 0)
            {
                Console.WriteLine("Du brichst verwundet zusammen...");
                return false;
            }
        }

        return spieler.HP > 0;
    }

    // Überreden: einfacher Charisma-Check
    protected override bool TryPersuade(Spieler spieler, Charakter gegner)
    {
        Goblin goblin = this.goblin;

        Console.WriteLine();
        Console.WriteLine($"Du versuchst, den {goblin.Name} zu überreden, dich in Ruhe zu lassen...");

        int wurf = _random.Next(1, 21); // 1–20
        int probe = wurf + spieler.Charisma;

        Console.WriteLine($"Wurf: {wurf} + Charisma {spieler.Charisma} = {probe}");

        if (probe >= 15)
        {
            Console.WriteLine($"{goblin.Name} scheint dir zu glauben und zieht sich zurück.");
            return true;
        }

        Console.WriteLine($"{goblin.Name} lacht dich aus und schickt dich weg!");
        return false;
    }

    // Schleichen: Stealth vs Wahrnehmung des Gegners
    protected override bool TrySneak(Spieler spieler, Charakter gegner)
    {
        Goblin goblin = this.goblin;

        Console.WriteLine();
        Console.WriteLine($"Du versuchst, dich am {goblin.Name} vorbeizuschleichen...");

        int wurf = _random.Next(1, 21); // 1–20
        int stealthWert = wurf + spieler.Stealth;

        Console.WriteLine($"Wurf: {wurf} + Schleichen {spieler.Stealth} = {stealthWert}");
        Console.WriteLine($"Wahrnehmung des Gegners: {goblin.Wahrnehmung}");

        if (stealthWert >= goblin.Wahrnehmung)
        {
            Console.WriteLine("Du verschwindest lautlos im Unterholz. Der Gegner bemerkt dich nicht.");
            return true;
        }

        Console.WriteLine($"Ein Ast knackt unter deinem Fuß – der {goblin.Name} bemerkt dich!");
        return false;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Der Wald wirkt plötzlich friedlicher. Du hast den Wald-Encounter erfolgreich geschafft.");
    }
}
