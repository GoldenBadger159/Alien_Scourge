using System;
using System.Collections.Generic;

public class Explore : Game
{
    private static Player p = new Player();
    public void GoExploring()
    {
        var random = new Random();
        string destination = ChooseLevel();
        Description(destination);
        int roll = FindItem();
        if (roll <= 9)
        {
            if (roll >= 3)
            {
                Console.WriteLine("You see an alien in the distance and move to engage.");
                Combat();
            }
            Console.WriteLine("You didn't find anything");
        } else if (roll >= 10)
        {
            if (roll >= 18)
            {
                Dictionary<string, int> weapons = GetWeapons();
                Dictionary<string, int>.KeyCollection w = weapons.Keys;
                List<string> weaponsL = w.ToList<string>();
                string weapon = weaponsL[random.Next(weaponsL.Count())];
                int damage = weapons[weapon];
                Console.WriteLine($"You found a {weapon}.");
                Console.WriteLine($"It can do {damage} damage.");
                Console.Write("Would you like to equip it? ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    p.EquipWeapon(weapon);
                } else
                {
                    AddArmory(weapon, damage);
                    Console.WriteLine($"{weapon} added to the community storage.");
                }
            } else {
                List<string> allGear = GetGear();
                string gear = allGear[random.Next(allGear.Count())];
                Console.WriteLine($"You found a {gear}.");
                Console.Write("Would you like to equip it? ");
                string decision = Console.ReadLine();
                if (decision.ToLower() == "yes")
                    {
                        p.EquipGear(gear);
                    } else
                    {
                        AddStorage(gear);
                        Console.WriteLine($"{gear} added to the community storage.");
                    }
            }
        }
    }
}