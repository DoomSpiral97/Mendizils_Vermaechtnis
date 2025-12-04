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
            Console.WriteLine("1) In den Tempel gehen");
            Console.WriteLine("2) Nach Gerüchten umhören");
            Console.WriteLine("3) In die Bar gehen");
            Console.WriteLine("0) Zurück in das Hauptmenü");
            Console.Write("Deine Wahl: ");

            string eingabe = Console.ReadLine();

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
        // Hier dann switchcase mit verschiedenen optionen, sprechen, heilen, gerüchte, Tempel ansehen
        bool inTempel = true;
        while (inTempel)
        {
            Console.WriteLine("Du betrittst den stillen Tempel. ");
            Console.WriteLine("1.Heilen");
            Console.WriteLine("2.Mit Priester reden");
            Console.WriteLine("3. Gerüchte lauschen");
            Console.WriteLine("4. Tempel ansehen");
            Console.WriteLine("0.Tempel verlassen");
            string eingabe = Console.ReadLine();
            
            switch (eingabe)
            {
                case "1":
                    Console.WriteLine("Du bittest einen Priester um Heilung und wirst geheilt");
                    spieler.HP = spieler.MaximaleHP;
                    Console.WriteLine($"Deine Lebenspunkte wurden erhöht. Aktuelle HP:{spieler.HP}");
                    break;

                case "2":

                    break;

                case "3":

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

    private static void BesucheBar(Spieler spieler)     // hier eine Liste mit textevents und daraus random picken, evtl kampf bei streitigkeit?
    {
        Console.WriteLine("In der Bar ist es laut und verraucht. Du trinkst einen kräftigen Schluck.");
        
        
        
    }
}