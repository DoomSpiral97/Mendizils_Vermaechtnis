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
}