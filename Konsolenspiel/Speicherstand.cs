using System.Text.Json;

namespace Konsolengame;

public static class Speicherstand
{
    private const string SaveFile = "savegame.json";

    public static void SpeichereSpieler(Spieler spieler)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(spieler, options);
        File.WriteAllText(SaveFile, json);
        Console.WriteLine("Spiel gespeichert.");
    }

    public static Spieler LadeSpieler()
    {
        if (!File.Exists(SaveFile))
        {
            return null;
        }

        string json = File.ReadAllText(SaveFile);
        Spieler spieler = JsonSerializer.Deserialize<Spieler>(json);
        return spieler;
    }
}