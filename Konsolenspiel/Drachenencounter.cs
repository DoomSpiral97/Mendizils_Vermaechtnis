namespace Konsolengame;

public class Drachenencounter :Encounter
{
   
    private readonly Gegner gegner = new Gegner
    {
        Stärke = 22,
        Beschreibung = "Ein Drache",
        HP = 70,
        MaximaleHP = 10,
        Name = "Hurdurrr",
        Wahrnehmnung = 2,
        Beleidigung = $"Der Drache spuckt Feuer ",
        SneakFail    = $"Noch bevor du den ersten leisen Schritt machen kannst, öffnet sich ein gewaltiges Drachenauge.\n\"Du willst dich AN MIR vorbeischleichen?\", donnert es, und die Höhle bebt vor Spott.",
        KampfFail    = $"Mit einem letzten Schlag seines Schweifes schleudert dich der Drache gegen die Felswand.\nDeine Finger lösen sich von Schild und Amulett, während alles um dich herum in Flammen und Dunkelheit versinkt.",
        ÜberredenFail = $"Du setzt an, von einer reicheren Stadt im Norden zu erzählen, doch der Drache schnaubt nur.\n\"Ich rieche Lügen – und Angst\", grollt er, bevor er die Klauen hebt und jede Diskussion beendet.",
    };

    

    public override void ShowIntro()
    {
        Console.WriteLine("Du verlässt die vertrauten Mauern der Stadt, das Gewicht von Mendizil Disis Ausrüstung auf deinen Schultern.\n" +
                          "Schild, Amulett und Kristall fühlen sich ungewohnt schwer an – aber in dir breitet sich eine stille Zuversicht aus.");
        Hilfsmethoden.Weiter();
    
        Console.WriteLine("\nDer Weg zur Drachenhöhle führt dich über ausgetrocknete Felder und zerklüftete Felsen,\n" +
                          "bis kein Gras mehr wächst und nur noch schwarzer, verbrannter Boden unter deinen Stiefeln knirscht.");
        Hilfsmethoden.Weiter();
    
        Console.WriteLine("\nVor dir klafft der Eingang zur Höhle wie ein offener Rachen im Berg.\n" +
                          "Schwefelgeruch liegt in der Luft, und irgendwo in der Tiefe hörst du das dumpfe Grollen eines gewaltigen Atems.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("Als du die ersten Schritte ins Dunkel setzt, flackert orangefarbenes Licht auf.");
        Hilfsmethoden.Weiter();
    }
    
    public override void PortraitAnsehen()
    {
        Console.WriteLine("                ^    ^\n               / \\  //\\\n |\\___/|      /   \\//  .\\\n /O  O  \\__  /    //  | \\ \\\n/     /  \\/_/    //   |  \\  \\\n@___@'    \\/_   //    |   \\   \\ \n   |       \\/_ //     |    \\    \\ \n   |        \\///      |     \\     \\ \n  _|_ /   )  //       |      \\     _\\\n '/,_ _ _/  ( ; -.    |    _ _\\.-~        .-~~~^-.\n ,-{        _      `-.|.-~-.           .~         `.\n  '/\\      /                 ~-. _ .-~      .-~^-.  \\\n     `.   {            }                   /      \\  \\\n   .----~-.\\        \\-'                 .~         \\  `. \\^-.\n  ///.----..>    c   \\             _ -~             `.  ^-`   ^-_\n    ///-._ _ _ _ _ _ _}^ - - - - ~                     ~--,   .-~\n                                                          /.-'");
    }

    public override void GameOverBild()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⢀⣴⣿⡶⠀⣾⣿⣿⡿⠟⠛⠁\n⠀⠀⠀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⣶⣶⣦⠀⠀⠀⠀⣼⣿⣿⡇⠀⣠⣿⣿⣿⠇⣸⣿⣿⣧⣤⠀⠀⠀\n⠀⠀⢀⣴⣾⣿⡿⠿⠿⠿⠇⠀⠀⣸⣿⣿⣿⡆⠀⠀⢰⣿⣿⣿⣷⣼⣿⣿⣿⡿⢀⣿⣿⡿⠟⠛⠁⠀⠀\n⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⢠⣿⣿⣹⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⢿⣿⣿⠃⣼⣿⣯⣤⣴⣶⣿⡤⠀\n⣼⣿⠏⠀⣀⣠⣤⣶⣾⣷⠄⣰⣿⣿⡿⠿⠻⣿⣯⣸⣿⡿⠀⠀⠀⠁⣾⣿⡏⢠⣿⣿⠿⠛⠋⠉⠀⠀⠀\n⣿⣿⠲⢿⣿⣿⣿⣿⡿⠋⢰⣿⣿⠋⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⠀⠀⠙⠛⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀\n⠹⢿⣷⣶⣿⣿⠿⠋⠀⠀⠈⠙⠃⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣴⣶⣦⣤⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣠⡇⢰⣶⣶⣾⡿⠷⣿⣿⣿⡟⠛⣉⣿⣿⣿⠆\n⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⡎⣿⣿⣦⠀⠀⠀⢀⣤⣾⠟⢀⣿⣿⡟⣁⠀⠀⣸⣿⣿⣤⣾⣿⡿⠛⠁⠀\n⠀⠀⠀⠀⣠⣾⣿⡿⠛⠉⢿⣦⠘⣿⣿⡆⠀⢠⣾⣿⠋⠀⣼⣿⣿⣿⠿⠷⢠⣿⣿⣿⠿⢻⣿⣧⠀⠀⠀\n⠀⠀⠀⣴⣿⣿⠋⠀⠀⠀⢸⣿⣇⢹⣿⣷⣰⣿⣿⠃⠀⢠⣿⣿⢃⣀⣤⣤⣾⣿⡟⠀⠀⠀⢻⣿⣆⠀⠀\n⠀⠀⠀⣿⣿⡇⠀⠀⢀⣴⣿⣿⡟⠀⣿⣿⣿⣿⠃⠀⠀⣾⣿⣿⡿⠿⠛⢛⣿⡟⠀⠀⠀⠀⠀⠻⠿⠀⠀\n⠀⠀⠀⠹⣿⣿⣶⣾⣿⣿⣿⠟⠁⠀⠸⢿⣿⠇⠀⠀⠀⠛⠛⠁⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠈⠙⠛⠛⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }

    public override void Überredenstext()
    {
        Console.WriteLine("Du hebst die Hände und versuchst, deine Stimme ruhig zu halten,\n" +
                          "während die Hitze aus dem Maul des Drachen dir das Gesicht versengt.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\n„Großer Drache“, beginnst du, „dieser Ort ist kaum mehr als ein armseliger Außenposten.\n" +
                          "Das Gold hier ist nichts im Vergleich zu dem, was weiter nördlich auf dich wartet.“");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nDas Ungeheuer neigt den Kopf, die Schuppen knacken leise.\n" +
                          "„Sprich weiter, Wurm“, grollt es, während seine Augen sich verengen.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\n„Hundert Meilen nördlich“, sagst du, „liegt eine Stadt, zehnmal so groß wie diese.\n" +
                          "Gefüllte Schatzkammern, Handelshäuser, Tempel voller Münzen – mehr Gold, als du hier je finden wirst.“");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nEinen Moment lang herrscht Stille, dann breitet der Drache langsam seine Schwingen aus.\n" +
                          "„Wenn du lügst, werde ich zurückkehren“, zischt er, „aber zuerst sehe ich mir diese Stadt an.“");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nMit einem ohrenbetäubenden Schlag seiner Flügel stößt er sich vom Boden ab\n" +
                          "und verschwindet als feuriger Schatten Richtung Norden am Himmel.");
        Hilfsmethoden.Weiter();
    }

    protected override Gegner GetGegner()
    {
        return gegner;
    }

    protected override void ShowQuestSuccess()
    {   Console.WriteLine("\nDie Höhle wirkt plötzlich größer, als der Drache verschwunden ist.\n" +
                          "Die Hitze weicht, und nur der Geruch von Asche und altem Gold bleibt zurück.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nOb durch Stahl, List oder Worte – der Drache ist keine Gefahr mehr für deine Stadt.\n" +
                          "Sein Schatten wird nicht länger über den Dächern liegen.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nDu wirfst einen letzten Blick auf den verlassenen Hort,\n" +
                          "dann drehst du dich um und trittst wieder hinaus in das kalte Tageslicht.");
        Hilfsmethoden.Weiter();

        Console.WriteLine("\nDer Rückweg fühlt sich leichter an als der Hinweg.\n" +
                          "Mit Mendizil Disis Ausrüstung an deiner Seite und dem Wissen um deinen Sieg\n" +
                          "gehst du zurück in die Stadt, die du eben vor einem Drachen bewahrt hast.");
        Hilfsmethoden.Weiter();
        Console.WriteLine();
        Console.WriteLine("Du hast den Schatz des Drachens erbeutet");
        Hilfsmethoden.HappyEnd();
        Hilfsmethoden.Weiter();
    }

 
}

