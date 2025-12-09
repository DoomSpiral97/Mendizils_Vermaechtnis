namespace Konsolengame;

public class Quests
{
    public static void WaldQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Item.Amulett))
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
                spieler.ItemHinzufügen(Item.Amulett);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
    }

    public static void MagisterQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Item.Schild))
        {
            Console.WriteLine("Du siehst noch leichte Rauchschwaden aus dem einstigen Anwesen aufsteigen");
        }
        else
        {
            var encounter = new Stadtencounter();
            bool stadtGeschafft = encounter.StartEncounter(spieler);

            if (stadtGeschafft)
            {
                spieler.ItemHinzufügen(Item.Schild);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
    }

    public static void RuinenQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Item.Kristall))
        {
            Console.WriteLine("Die Ruinen sind ruhig, du siehst dass sich  deinem letzten Besuch ein paar Blumen gesprossen sind. ");
        }
        else
        {
            var encounter = new Ruinenencounter();
            bool ruineGeschafft = encounter.StartEncounter(spieler); 

            if (ruineGeschafft)
            {
                spieler.ItemHinzufügen(Item.Kristall);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        }
        
        
    }

    public static void DrachenQuest(Spieler spieler)
    {
        if (spieler.Inventar.Contains(Item.Kristall) &&
            spieler.Inventar.Contains(Item.Schild) &&
            spieler.Inventar.Contains(Item.Amulett))
        {
            var encounter = new Drachenencounter();
            bool dracheGeschafft = encounter.StartEncounter(spieler);

            if (dracheGeschafft)
            {
                Console.WriteLine(
                    "Du kehrst erfolgreich in die Stadt zurück mit dem Schatz des Drachen in deinem Beutel");
                spieler.ItemHinzufügen(Item.Goldkiste);
            }
            else
            {
            }
        }

        

        else if(spieler.Inventar.Contains(Item.Kristall) &&
         spieler.Inventar.Contains(Item.Schild) &&
         spieler.Inventar.Contains(Item.Amulett)&& spieler.Inventar.Contains(Item.Goldkiste))
        {
            Console.WriteLine("Aasfresser haben begonnen an den Überresten des Drachen zu nagen. Du denkst an deine alten Heldentaten zurück und gehst mit einem Lächeln auf den Lippen zurück in die Stadt.");
        }
        else
        {
            Console.WriteLine("Du machst dich auf den Weg zur Drachenhöhle, den Hang hinauf zwischen verkohlten Felsen und verbrannter Erde.\n Als du den Eingang erreichst, stehst du nicht vor einem offenen Rachen im Fels, sondern vor einer schweren Steintür.\nIn den Stein sind Muster eingelassen – verschlungene Linien, die sich schließlich zu der klaren Form eines Schildes fügen.\nDu tastest über die Gravur und spürst sofort: Ohne das passende Schild wirst du hier keinen Schritt weiterkommen.\nDaneben sind noch zwei weitere Formen die du nicht genau erkennen kannst.\nDu gehst enttäuscht zurück in die Stadt...");

        }
        
    }
    public static void BarQuest(Spieler spieler)
    {
        
            var encounter = new Barencounter();
            bool barGeschafft = encounter.StartEncounter(spieler); 

            if (barGeschafft)
            {
                spieler.ItemHinzufügen(Item.Bier);
            }
            else
            {
                Console.WriteLine("Niedergeschlagen kehrst du in die Stadt zurück...");
            }
        
    }
}