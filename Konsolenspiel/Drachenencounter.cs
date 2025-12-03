namespace Konsolengame;

public class Drachenencounter :Encounter
{
   
    private readonly Drache _drache = new Drache
    {
        Stärke = 22,
        Beschreibung = "Ein Drache",
        Charisma = 0,
        HP = 300,
        MaximaleHP = 10,
        Stealth = 2,
        Name = "Hurdurrr",
        Wahrnehmnung = 2,
        Beleidigung = $"Der Drache spuckt Feuer "
    };

    public Drachenencounter()
    {
        Name = "Drachenhöhle";
    }

    public override void ShowIntro()
    {
        Console.WriteLine("Du gehst in die Höhle des Drachen");
    }
    
    public override void PortraitAnsehen()
    {
        Console.WriteLine("                ^    ^\n               / \\  //\\\n |\\___/|      /   \\//  .\\\n /O  O  \\__  /    //  | \\ \\\n/     /  \\/_/    //   |  \\  \\\n@___@'    \\/_   //    |   \\   \\ \n   |       \\/_ //     |    \\    \\ \n   |        \\///      |     \\     \\ \n  _|_ /   )  //       |      \\     _\\\n '/,_ _ _/  ( ; -.    |    _ _\\.-~        .-~~~^-.\n ,-{        _      `-.|.-~-.           .~         `.\n  '/\\      /                 ~-. _ .-~      .-~^-.  \\\n     `.   {            }                   /      \\  \\\n   .----~-.\\        \\-'                 .~         \\  `. \\^-.\n  ///.----..>    c   \\             _ -~             `.  ^-`   ^-_\n    ///-._ _ _ _ _ _ _}^ - - - - ~                     ~--,   .-~\n                                                          /.-'");
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Das Drache ist eigentlich recht chill.");
    }

    protected override Charakter GetGegner()
    {
        return _drache;
    }

    protected override void ShowQuestSuccess()
    {
        Console.WriteLine();
        Console.WriteLine("Du hast den Schatz des Drachens erbeutet");
    }

 
}

