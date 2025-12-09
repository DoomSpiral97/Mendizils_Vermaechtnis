namespace Konsolengame;

public static class StadtErkunden
{
    public static void Start(Spieler spieler)
    {
        bool inStadt = true;

        while (inStadt)
        {
            
            Console.WriteLine();
            Console.WriteLine("Du schlenderst durch die Stadt. Was möchtest du tun?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1) In den Tempel gehen");
            Console.WriteLine("2) Nach Gerüchten umhören");
            Console.WriteLine("3) In die Bar gehen");
            Console.WriteLine("4) Sich im Brunnen anschauen");
            Console.WriteLine("0) Zurück in das Hauptmenü");
            Console.ResetColor();
            Console.Write("Deine Wahl: ");
            

            string eingabe = Console.ReadLine().ToLower();

            switch (eingabe)
            {
                case "1":
                    BesuchTempel(spieler);
                    break;

                case "2":
                    HoereGeruechte(spieler);
                    break;

                case "3":
                    BesucheBar(spieler);
                    break;
                
                case "4":
                    Console.WriteLine("Du beugst dich zu Brunnen und siehst dein Spigelbild im klaren Wasser");
                    Console.WriteLine($"{spieler.Portrait}");
                    break;

                case "0":
                    inStadt = false;
                    break;
                
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }
    }

    private static void BesuchTempel(Spieler spieler)
    {
        bool inTempel = true;
        while (inTempel)
        {
            Console.WriteLine("Du betrittst den stillen Tempel. ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1.Heilen");
            Console.WriteLine("2.Mit Priester reden");
            Console.WriteLine("3. Gerüchte lauschen");
            Console.WriteLine("4. Tempel ansehen");
            Console.WriteLine("0.Tempel verlassen");
            Console.ResetColor();
            string eingabe = Console.ReadLine();
            
            switch (eingabe)
            {
                case "1":
                    Console.WriteLine("Du bittest einen Priester um Heilung und wirst geheilt");
                    if (spieler.HP < spieler.MaximaleHP)
                    {
                        spieler.HP = spieler.MaximaleHP;
                        Console.WriteLine($"Deine Lebenspunkte wurden erhöht. Aktuelle HP:{spieler.HP}");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Du hast bereits volle HP");
                        break;
                    }
                    

                case "2":
                    Console.WriteLine(
                        "Der Priester lächelt mild, als du den goldenen Altar betrachtest.\n" +
                        "„Beeindruckend, nicht wahr? Und doch gehört dieses Gold keiner Krone und keinem Magister.“\n" +
                        "Er senkt die Stimme. „Vor tausend Jahren brachte eine Heldin einen Drachenschatz hierher – " +
                        "sie hätte sich Paläste bauen können, doch sie bat nur um einen Tempel für die Stadt.“\n" +
                        "„Seitdem erinnern diese Mauern daran, dass wahrer Ruhm nicht im Horten von Gold liegt,\n" +
                        "sondern darin, was man bereit ist, für andere zu opfern.“"
                    );

                    break;

                case "3":
                        HoereGeruechte(spieler);
                    break;
                
                case "4":
                    Console.WriteLine("               )\\         O_._._._A_._._._O         /(\n                \\`--.___,'=================`.___,--'/\n                 \\`--._.__                 __._,--'/\n                   \\  ,. l`~~~~~~~~~~~~~~~'l ,.  /\n       __            \\||(_)!_!_!_.-._!_!_!(_)||/            __\n       \\\\`-.__        ||_|____!!_|;|_!!____|_||        __,-'//\n        \\\\    `==---='-----------'='-----------`=---=='    //\n        | `--.                                         ,--' |\n         \\  ,.`~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~',.  /\n           \\||  ____,-------._,-------._,-------.____  ||/\n            ||\\|___!`=======\"!`=======\"!`=======\"!___|/||\n            || |---||--------||-| | |-!!--------||---| ||\n  __O_____O_ll_lO_____O_____O|| |'|'| ||O_____O_____Ol_ll_O_____O__\n  o H o o H o o H o o H o o |-----------| o o H o o H o o H o o H o\n ___H_____H_____H_____H____O =========== O____H_____H_____H_____H___\n                          /|=============|\\\n()______()______()______() '==== +-+ ====' ()______()______()______()\n||{_}{_}||{_}{_}||{_}{_}/| ===== |_| ===== |\\{_}{_}||{_}{_}||{_}{_}||\n||      ||      ||     / |==== s(   )s ====| \\     ||      ||      ||\n======================()  =================  ()======================\n----------------------/| ------------------- |\\----------------------\n                     / |---------------------| \\\n-'--'--'           ()  '---------------------'  ()\n                   /| ------------------------- |\\    --'--'--'\n       --'--'     / |---------------------------| \\    '--'\n                ()  |___________________________|  ()           '--'-\n  --'-          /| _______________________________  |\\\n --'           / |__________________________________| \\");
                    break;
                

                case "0":
                    Console.WriteLine("Du verlässt den Tempel");
                    inTempel = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }
        
    }

    private static void HoereGeruechte(Spieler spieler)
    {
        Gerüchte.GerüchteHören(spieler);
    }

    private static void
        BesucheBar(Spieler spieler) 
    {
        bool inBar = true;
        Console.WriteLine("Du betrittst die verrauchte Bar ");
        while (inBar)
        {   Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1.Ein Bier Bestellen");
            Console.WriteLine("2.Zimmer nehmen");
            Console.WriteLine("0.Bar verlassen");
            Console.ResetColor();
            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    if (spieler.Inventar.Contains(Items.Schild)&&!spieler.Inventar.Contains(Items.Bier))
                    {
                        Quests.BarQuest(spieler);
                    }
                    

                    else if(spieler.Inventar.Contains(Items.Kristall))
                {
                    Console.WriteLine($"Du gehst richtung Bar, als eine alte Greisin dich am Arm packt\nDu bist doch{spieler.Name}, ICh habe gehört, dass du bei den Ruinen für Ruhe gesorg hast. \nVielen Dank! Endlich kann ich meinem Karl wieder Blumen bringen.");
                }
                    else if (spieler.Inventar.Contains(Items.Amulett))
                    {
                        Console.WriteLine("Ein kleines Kind spricht dich an und dankt dir, dass es jetzt wieder im Wald spielen kann.\n Du sagst Ihm, das eine Bar kein Ort für Kinder ist.");
                    }
                    else
                    {
                        Console.WriteLine("Du trinkst Bier. Es schmeckt nicht.");
                        spieler.HP -= 20;
                    }

                    break;

                case "2":
                    Console.WriteLine("Du nimmst dier ein Zimmer und ruhst dich aus");
                    if (spieler.HP+20 <= spieler.MaximaleHP )
                    spieler.HP += 20;
                    break;
                
                case "0":
                    Console.WriteLine("Du verlässt die Bar, deine Kleidung riecht nach Rauch ");
                    inBar = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }
    }
}