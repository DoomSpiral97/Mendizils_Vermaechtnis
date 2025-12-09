namespace Konsolengame;

public class Item
{
    public string Name { get; set; }
    public string Beschreibung { get; set; }

    public Item(string name,string beschreibung)
    {
        Name = name;
        Beschreibung = beschreibung;
    }
    public static Item Kristall = new Item("Kristall","Der Kristall den du aus den Ruinen erbeutet hast");
    public static Item Schild   = new Item("Schild","Ein Schild aus der Kammer des Magisters, er soll früher einer Heldin gehört haben");
    public static Item Amulett  = new Item("Amulett","Ein Amulett, welches du im Wald gefunden hast");
    public static Item Goldkiste  = new Item("Goldkiste","Eine Kiste voll Gold");
    public static Item Bier = new Item("Bier","Eine besonders leckeres Bier");
    public static Item Hilferuf = new Item("Hilferuf","Ein Hilferuf aus der Stadt");
}
