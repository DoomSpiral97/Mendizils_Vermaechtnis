namespace Konsolengame;

public class Quests
{
    public static void WaldQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Items.Amulett))
        {
            Console.WriteLine("Der Wald ist friedlich geworden seitdem du das Amulett an dich genommen hast. Du genießt die Ruhe für einen Moment und kehrst zurück in die Stadt");
            if (spieler.HP < spieler.MaximaleHP)
            {
                spieler.HP += 10;
            }
        }
        else
        {
            var encounter = new WaldEncounter();
            bool waldGeschafft = encounter.StartEncounter(spieler); // Gegner kommt aus GetGegner()

            if (waldGeschafft)
            {
                spieler.ItemHinzufügen(Items.Amulett);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
    }

    public static void MagisterQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Items.Schild))
        {
            Console.WriteLine("Du siehst noch leichte Rauchschwaden aus dem einstigen Anwesen aufsteigen");
        }
        else
        {
            var encounter = new Stadtencounter();
            bool stadtGeschafft = encounter.StartEncounter(spieler);

            if (stadtGeschafft)
            {
                spieler.ItemHinzufügen(Items.Schild);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
    }

    public static void RuinenQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Items.Kristall))
        {
            Console.WriteLine("Die Ruinen sind ruhig, du siehst dass sich  deinem letzten Besuch ein paar Blumen gesprossen sind. ");
        }
        else
        {
            var encounter = new Ruinenencounter();
            bool ruineGeschafft = encounter.StartEncounter(spieler); 

            if (ruineGeschafft)
            {
                spieler.ItemHinzufügen(Items.Kristall);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
        
        
    }

    public static void DrachenQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Items.Kristall) &&
            spieler.Inventar.Contains(Items.Schild) &&
            spieler.Inventar.Contains(Items.Amulett))
        {
            var encounter = new Drachenencounter();
            bool dracheGeschafft = encounter.StartEncounter(spieler);

            if (dracheGeschafft)
            {
                Console.WriteLine(
                    "Du kehrst erfolgreich in die Stadt zurück mit dem Schatz des Drachen in deinem Beutel");
                spieler.ItemHinzufügen(Items.Goldkiste);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }

        

        else if(spieler.Inventar.Contains(Items.Kristall) &&
         spieler.Inventar.Contains(Items.Schild) &&
         spieler.Inventar.Contains(Items.Amulett)&& spieler.Inventar.Contains(Items.Goldkiste))
        {
            Console.WriteLine("Aasfresser haben begonnen an den Überresten des Drachen zu nagen. Du denkst an deine alten Heldentaten zurück und gehst mit einem Lächeln auf den Lippen zurück in die Stadt.");
        }
        else
        {
            Console.WriteLine(
                "Du stehst vor dem Drachen und merkst, dass du keine Chance hast. Du rennst zurück in die sichere Stadt.");
        }
        
    }
    public static void BarQuest(Spieler spieler)
    {
        
            var encounter = new Barencounter();
            bool barGeschafft = encounter.StartEncounter(spieler); 

            if (barGeschafft)
            {
                spieler.ItemHinzufügen(Items.Bier);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        
    }
}