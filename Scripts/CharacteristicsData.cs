using System.Collections.Generic;

namespace Card;

public class CharacteristicsData
{
    private Dictionary<int, string> db = new Dictionary<int, string>
    {
        { 1, "HEATHCLIFF" },
        { 2, "CATHY" },
        { 3, "HINDLEY" }
    };

    public string GetInfo(int key)
    {
        return db.ContainsKey(key) ? db[key] : "Unknown";
    }
}
