using System.Collections.Generic;

namespace Card;

public class CharacteristicsData
{
    private Dictionary<int, string> db = new Dictionary<int, string>
    {
        { 1, "Heathcliff" },
        { 2, "Catherine" },
        { 3, "Hindley" }
    };

    public string GetInfo(int key)
    {
        return db.ContainsKey(key) ? db[key] : "Unknown";
    }
}
