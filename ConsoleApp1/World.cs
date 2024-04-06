using System;

public class World
{
    private List<string> _gearStorage = new List<string>();
    private Dictionary<string, int> _armory = new Dictionary<string, int>();
    private List<string> _gear = new List<string>(){
        "bandages", "crowbar", "hammer", "saw", "screw driver", "pickaxe", "sewing kit"
    };
    private Dictionary<string, int> _weapons = new Dictionary<string, int>(){
        {"bat", 5}, {"sword", 15}, {"warhammer", 15}, {"pistol", 20}, {"rifle", 30}, {"shotgun", 40}
    };
    private List<string> _levels = new List<string>(){
        "Forest","Abandoned Cottage", "Appartment Complex", "Old Super Store", "Office Building",
        "Abandoned School", "Police Station", "Sports Stadium"
    };
    private List<int> _enemies = new List<int>(){
        10, 15, 20, 30
    };
    public Dictionary<string, int> GetArmory()
    {
        return _armory;
    }
    public void AddArmory(string name, int damage)
    {
        _armory.Add(name, damage);
    }
    public void AddStorage(string item)
    {
        _gearStorage.Add(item);
    }
    public Dictionary<string, int> GetWeapons()
    {
        return _weapons;
    }
    public List<string> GetGearStorage()
    {
        return _gearStorage;
    }
    public List<string> GetGear()
    {
        return _gear;
    }
    public List<int> GetEnemies()
    {
        return _enemies;
    }
    public List<string> GetLevels()
    {
        return _levels;
    }
    public int RollDice(int bonus)
    {
        var random = new Random();
        return random.Next(20) + bonus;
    }
    
}
