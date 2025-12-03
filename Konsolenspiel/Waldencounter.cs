using Konsolengame;

public class WaldEncounter : Encounter
{
    private readonly Goblin goblin = new Goblin
    {
        Stärke = 22,
        Beschreibung = "Ein fieser Goblin",
        Charisma = 0,
        HP = 300,
        MaximaleHP = 10,
        Stealth = 2,
        Name = "Groff der Brecher",
        Wahrnehmnung = 2,
        Beleidigung = $"Ich werde dich zu Wurst verarbeiten!"
    };

    public WaldEncounter()
    {
        Name = "Düsterer Wald";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst einen düsteren Wald. Zwischen den Bäumen raschelt etwas...");
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Du überredest Groff indem du ihm erzählst, dass in nächsten Dorf eine süße Katze ist.");
    }

    protected override Charakter GetGegner()
    {
        return goblin;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Der Wald wirkt plötzlich friedlicher. Du hast den Wald-Encounter erfolgreich geschafft.");
    }

 
}