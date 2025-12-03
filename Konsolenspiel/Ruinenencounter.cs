namespace Konsolengame;

public class Ruinenencounter : Encounter
{
    private readonly Skelett _skelett = new Skelett
    {
        Stärke = 22,
        Beschreibung = "Ein Skelett",
        Charisma = 0,
        HP = 300,
        MaximaleHP = 10,
        Stealth = 2,
        Name = "Knochenkarl",
        Wahrnehmnung = 2,
        Beleidigung = $"*das Skelett klappert wütend mit seinem Unterkiefer"
    };

    public Ruinenencounter()
    {
        Name = "Gruft";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du betrittst die Gruft die unter den Ruinen liegt,");
    }
    
    public override void PortraitAnsehen()
    {
        Console.WriteLine("                              _.--\"\"-._\n  .                         .\"         \".\n / \\    ,^.         /(     Y             |      )\\\n/   `---. |--'\\    (  \\__..'--   -   -- -'\"\"-.-'  )\n|        :|    `>   '.     l_..-------.._l      .'\n|      __l;__ .'      \"-.__.||_.-'v'-._||`\"----\"\n \\  .-' | |  `              l._       _.'\n  \\/    | |                   l`^^'^^'j\n        | |                _   \\_____/     _\n        j |               l `--__)-'(__.--' |\n        | |               | /`---``-----'\"1 |  ,-----.\n        | |               )/  `--' '---'   \\'-'  ___  `-.\n        | |              //  `-'  '`----'  /  ,-'   I`.  \\\n      _ L |_            //  `-.-.'`-----' /  /  |   |  `. \\\n     '._' / \\         _/(   `/   )- ---' ;  /__.J   L.__.\\ :\n      `._;/7(-.......'  /        ) (     |  |            | |\n      `._;l _'--------_/        )-'/     :  |___.    _._./ ;\n        | |                 .__ )-'\\  __  \\  \\  I   1   / /\n        `-'                /   `-\\-(-'   \\ \\  `.|   | ,' /\n                           \\__  `-'    __/  `-. `---'',-'\n                              )-._.-- (        `-----'\n                             )(  l\\ o ('..-.\n                       _..--' _'-' '--'.-. |\n                __,,-'' _,,-''            \\ \\\n               f'. _,,-'                   \\ \\\n              ()--  |                       \\ \\\n                \\.  |                       /  \\\n                  \\ \\                      |._  |\n                   \\ \\                     |  ()|\n                    \\ \\                     \\  /\n                     ) `-.                   | |\n                    // .__)                  | |\n                 _.//7'                      | |\n               '---'                         j_| `\n                                            (| |\n                                             |  \\\n                                             |lllj\n                                             |||||"); 
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Das Skelett geht zurück in den Sarg");
    }

    protected override Charakter GetGegner()
    {
        return _skelett;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Du hast das Schild aus der Kammer des Magistrats erbeutet.");
    }

 
}
