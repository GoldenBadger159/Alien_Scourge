using System;

public class Player : World
{
    private int _health = 50;
    private int _baseDamage = 5;
    private int _level = 1;
    private int _exp = 0;
    private string _weaponName;
    private int _weaponDamage;
    public int GetEXP()
    {
        return _exp;
    }
    public void GainEXP(int exp)
    {
        _exp += exp;
        if (_exp >= (500 * _level))
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        _health += 5;
        _baseDamage += 1;
        _level += 1;
    }
    public int GetPlayerHP()
    {
        return _health;
    }
    private List<string> _equipment = new List<string>(){
        "bandages"
    };
    public void EquipGear(string item)
    {
        if (_equipment.Count() <= 3)
        {
            _equipment.Add(item);
            Console.WriteLine($"{item} equipped.");
        }
        else{
            Console.WriteLine("Only three pieces of gear can be equipped at a time.");
        }
    }
    public void EquipWeapon(string item)
    {
        Dictionary<string, int> weapons = GetWeapons();
        try{
            _weaponDamage = weapons[item];
            _weaponName = item;
            Console.WriteLine($"{item} equipped.");
        } catch {
            Console.WriteLine("that is not a valid weapon.");
        }
    }
    public int GetBonus()
    {
        return _equipment.Count();
    }
    public int Attack()
    {
        int maxDamage = _baseDamage + _weaponDamage;
        var random = new Random();
        int damage;
        do {
            damage = random.Next(maxDamage);
        } while (damage < (maxDamage / 5));
        return damage;
    }
}