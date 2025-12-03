namespace Konsolengame;

public class Charakter
{
    public int HP { get; set; }
    public int MaximaleHP { get; set; }
    public int Stärke { get; set; }
    public int Charisma { get; set; }
    public int Stealth { get; set; }
    public string Beschreibung { get; set; } 
    public string Name { get; set; }
    public int Wahrnehmnung{get;set;}
    public string Beleidigung{ get;set;}
    
    public string Portrait { get; set; }
}