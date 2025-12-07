namespace Konsolengame;

public class Barencounter:Encounter
{
    private readonly Gegner gegner = new Gegner
    {
        Stärke = 14,
        Beschreibung = "Ein wütender Wachmann mit verkniffenem Blick",
        Charisma = 0,
        HP = 50,
        MaximaleHP = 50,
        Stealth = 2,
        Name = "Gusir Sigurdson",
        Wahrnehmnung = 25,

        Beleidigung = 
            $"„Wegen dir hat mein Bruder seinen Posten verloren! Ich prügle dir das Schild aus den Händen!“",

        SneakFail =
            $"Du wirfst die Rauchbombe zu früh, sie prallt an der Tür ab und rollt direkt vor Gusirs Stiefel.\n" +
            $"Der Rauch steigt dir ins Gesicht, während er nur hustend sein Schwert zieht.\n" +
            $"„Genialer Plan“, knurrt er. „Jetzt seh ich dich zwar schlechter – aber du mich auch!“",

        KampfFail =
            $"Ein harter Schlag seines Knüppels trifft dich an der Schläfe.\n" +
            $"„So sieht also der große Schilddieb aus“, zischt Gusir, während dir die Lichter ausgehen.\n" +
            $"„Das erzähl ich meinem Bruder. Vielleicht lacht er dann wenigstens einmal heute.“",

        ÜberredenFail =
            $"Du setzt an: „Hör zu, ich kenne da jemanden in Ehrenfort, der dir einen besseren Job—“\n" +
            $"Gusir verschränkt die Arme und verengt die Augen.\n" +
            $"„Natürlich“, sagt er trocken, „und ich bin der König von Ehrenfort.\" \n" +
            $"Bevor du weitersprechen kannst, haut er dir eine und schleudert dich die Stufen hinunter."
    };
    public override void Überredenstext()
    {
        Console.WriteLine("Du hebst die Hände, bevor Gusir nach seinem Knüppel greifen kann,\n" +
                          "und versuchst, seine Wut in Worte zu fassen, bevor sie dich trifft.");
        Console.ReadKey();

        Console.WriteLine("\n„Du bist Gusir, oder? Der Bruder der Wache, die vor dem Haus Dienst hatte…“");
        Console.ReadKey();

        Console.WriteLine("\nSein Blick wird noch härter. „Schön, dass sich sogar Diebe daran erinnern“, knurrt er.\n" +
                          "„Wegen dir ist er seinen Posten los.“");
        Console.ReadKey();

        Console.WriteLine("\n„Wegen des Magisters“, korrigierst du ruhig.\n" +
                          "„Der wirft Leute weg wie altes Brot. Aber ich kenne jemanden in Ehrenfort,\n" +
                          "der gute Kämpfer sucht – für deutlich besseren Sold.“");
        Console.ReadKey();

        Console.WriteLine("\nEin Moment des Zögerns. Die Knöchel an seinem Griff werden weiß,\n" +
                          "doch er hat noch nicht zugeschlagen.");
        Console.ReadKey();

        Console.WriteLine("\n„Dein Bruder könnte dort arbeiten, ohne sich vor korrupten Feiglingen verbeugen zu müssen“,\n" +
                          "setzt du nach. „Und ohne dass dein Familienname an diesem Haus hier klebt.“");
        Console.ReadKey();

        Console.WriteLine("\nGusir atmet schwer aus, als würde er einen unsichtbaren Helm ablegen.\n" +
                          "„Wenn du lügst, finde ich dich“, sagt er leise, „aber wenn du recht hast…“");
        Console.ReadKey();

        Console.WriteLine("\nEr tritt zur Seite, die Hand vom Knüppel gelöst.\n" +
                          "„Dann soll der Magister sehen, wie er ohne unsere Familie auskommt. Geh schon.“");
        Console.ReadKey();
    }
    protected override Gegner GetGegner()
    {
        return gegner;
    }
    public override void ShowIntro()
    {
        Console.WriteLine("Die Taverne ist heute Abend überfüllt, Stimmen und Gelächter vermischen sich\n" +
                          "mit dem süßlichen Geruch von Bier und Rauch.");
        Console.ReadKey();

        Console.WriteLine("\nDu bahnst dir den Weg zur Bar, schiebst betrunkene Gäste und klappernde Krüge beiseite,\n" +
                          "bis deine Finger fast schon den Tresen berühren.");
        Console.ReadKey();

        Console.WriteLine("\nPlötzlich schießt eine Hand vor und packt dich hart am Arm.\n" +
                          "Ein über zwei Meter großer Mann, schwankend vor Alkohol, zieht dich zu sich herum.");
        Console.ReadKey();

        Console.WriteLine("\nSein Blick ist glasig, aber voller Wut.\n" +
                          "„Ich bin Gusir Sigurdson“, knurrt er, Bieratem direkt in deinem Gesicht,\n" +
                          "„und wegen dir hat mein Bruder seinen Posten verloren…“");
        Console.ReadKey();

        Console.WriteLine("\nEr stößt dich gegen den Tresen, dass die Krüge klirren.\n" +
                          "„Also, Schilddieb… wollen wir das hier klären.“");
        Console.ReadKey();
    }
    protected override void ShowQuestSuccess()
    {
        Console.WriteLine("\nDie Spannung in der Taverne fällt langsam ab, wie Rauch, der zur Decke zieht.");
        Console.ReadKey();

        Console.WriteLine("\nGusir wirft dir noch einen letzten, prüfenden Blick zu,\n" +
                          "nickt knapp und lässt deine Schulter los.");
        Console.ReadKey();

        Console.WriteLine("\n„Dann sind wir quitt“, murmelt er schließlich,\n" +
                          "dreht sich um und verschwindet in der Menge aus Gästen und Krügen.");
        Console.ReadKey();

        Console.WriteLine("\nDu setzt dich an die Bar, der Wirt stellt wortlos einen frischen Krug vor dich hin.\n" +
                          "Zum ersten Mal seit du die Taverne betreten hast, kannst du dein Bier in Ruhe trinken.");
        Console.ReadKey();
    }
    public override void PortraitAnsehen()
    {
        Console.WriteLine("  ,   A           {}\n / \\, | ,        .--.\n|    =|= >      /.--.\\\n \\ /` | `       |====|\n  `   |         |`::`|  \n      |     .-;`\\..../`;_.-^-._\n     /\\\\/  /  |...::..|`   :   `|\n     |:'\\ |   /'''::''|   .:.   |\n      \\ /\\;-,/\\   ::  |..:::::..|\n      |\\ <` >  >._::_.| ':::::' |\n      | `\"\"`  /   ^^  |   ':'   |\n      |       |       \\    :    /\n      |       |        \\   :   / \n      |       |___/\\___|`-.:.-`\n      |        \\_ || _/    `\n      |        <_ >< _>\n      |        |  ||  |\n      |        |  ||  |\n      |       _\\.:||:./_\n      |      /____/\\____\\");
    }

    public override void GameOverBild()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣤⠀⠀⠀⢀⣴⣿⡶⠀⣾⣿⣿⡿⠟⠛⠁\n⠀⠀⠀⠀⠀⠀⣀⣀⣄⣀⠀⠀⠀⠀⣶⣶⣦⠀⠀⠀⠀⣼⣿⣿⡇⠀⣠⣿⣿⣿⠇⣸⣿⣿⣧⣤⠀⠀⠀\n⠀⠀⢀⣴⣾⣿⡿⠿⠿⠿⠇⠀⠀⣸⣿⣿⣿⡆⠀⠀⢰⣿⣿⣿⣷⣼⣿⣿⣿⡿⢀⣿⣿⡿⠟⠛⠁⠀⠀\n⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⢠⣿⣿⣹⣿⣿⣿⣿⣿⣿⡏⢻⣿⣿⢿⣿⣿⠃⣼⣿⣯⣤⣴⣶⣿⡤⠀\n⣼⣿⠏⠀⣀⣠⣤⣶⣾⣷⠄⣰⣿⣿⡿⠿⠻⣿⣯⣸⣿⡿⠀⠀⠀⠁⣾⣿⡏⢠⣿⣿⠿⠛⠋⠉⠀⠀⠀\n⣿⣿⠲⢿⣿⣿⣿⣿⡿⠋⢰⣿⣿⠋⠀⠀⠀⢻⣿⣿⣿⠇⠀⠀⠀⠀⠙⠛⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀\n⠹⢿⣷⣶⣿⣿⠿⠋⠀⠀⠈⠙⠃⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠈⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣴⣶⣦⣤⡀⠀\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⣠⡇⢰⣶⣶⣾⡿⠷⣿⣿⣿⡟⠛⣉⣿⣿⣿⠆\n⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⡎⣿⣿⣦⠀⠀⠀⢀⣤⣾⠟⢀⣿⣿⡟⣁⠀⠀⣸⣿⣿⣤⣾⣿⡿⠛⠁⠀\n⠀⠀⠀⠀⣠⣾⣿⡿⠛⠉⢿⣦⠘⣿⣿⡆⠀⢠⣾⣿⠋⠀⣼⣿⣿⣿⠿⠷⢠⣿⣿⣿⠿⢻⣿⣧⠀⠀⠀\n⠀⠀⠀⣴⣿⣿⠋⠀⠀⠀⢸⣿⣇⢹⣿⣷⣰⣿⣿⠃⠀⢠⣿⣿⢃⣀⣤⣤⣾⣿⡟⠀⠀⠀⢻⣿⣆⠀⠀\n⠀⠀⠀⣿⣿⡇⠀⠀⢀⣴⣿⣿⡟⠀⣿⣿⣿⣿⠃⠀⠀⣾⣿⣿⡿⠿⠛⢛⣿⡟⠀⠀⠀⠀⠀⠻⠿⠀⠀\n⠀⠀⠀⠹⣿⣿⣶⣾⣿⣿⣿⠟⠁⠀⠸⢿⣿⠇⠀⠀⠀⠛⠛⠁⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀\n⠀⠀⠀⠀⠈⠙⠛⠛⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }

}