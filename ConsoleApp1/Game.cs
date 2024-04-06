using System;

public class Game : World
{
    private static Player p = new Player();
    public int FindItem()
    {
        return RollDice(p.GetBonus());

    }
    public string ChooseLevel()
    {
        var random = new Random();
        List<string> levels = GetLevels();
        List<string> levelOptions = new List<string>();
        for (int i = 0; i < 4; i++)
        {
            string level;
            do {
                level = levels[random.Next(levels.Count())];
            } while (!levels.Contains(level));
            levelOptions.Add(level);
            Console.WriteLine($"{i + 1}: {level}");
        }
        Console.Write("Which area would you like to go to?");
        string choice = Console.ReadLine();
        string destination = levelOptions[int.Parse(choice) - 1];
        return destination;
    }
    // "Forest","Abandoned Cottage", "Appartment Complex", "Old Super Store", "Office Building",
    //  "Abandoned School", "Police Station", "Sports Stadium"
    public void Description(string destination)
    {
        switch (destination)
        {
            case "Forest":
                Console.WriteLine("The Forest is dense and damp all around you. Your coat keeps you warm in the mid morning chill");
                Console.WriteLine("Ahead you see a pile of junk, Likely what's left of someone's camp. You search it for anything useful.");
                break;
            case "Abandoned Cottage":
                Console.WriteLine("Deep in the woods you happen upon what's left of a summer get away cottage.");
                Console.WriteLine("Hoping to find something uesful you move to search the building.");
                break;
            case "Appartment Complex":
                Console.WriteLine("Deep in the ruins of the city a mostly intact appartment complex stands silently and resolute.");
                Console.WriteLine("Thinking perhaps you'll get lucky and find something looters haven't already taken for themselves");
                break;
            case "Old Super Store":
                Console.WriteLine("In the suburbs surrounding a nearby city you find the suprisingly well preserved remains of an old superstore.");
                Console.WriteLine("With any luck you'll find something useful inside.");
                break;
            case "Office Building":
                Console.WriteLine("The industrial district of a small town still holds a few intact office structures.");
                Console.WriteLine("You pick one and go to explore.");
                break;
            case "Abandoned School":
                Console.WriteLine("Plenty of schools existed before the apocalypse, perhaps this one still holds something for you.");
                break;
            case "Police Station":
                Console.WriteLine("In the center of the city lies a crumbling building you can barely recognize as an old police station.");
                Console.WriteLine("Perhaps it's destroyed state preserved some useful equipment from the destructive hands of looters.");
                break;
            case "Sports Stadium":
                Console.WriteLine("Like a monolith of the past this sports stadium managed not to be destroyed during the initial invasion");
                Console.WriteLine("Early after the collapse of society it would've been used as a shelter for many people. perhaps they left something behind.");
                break;
        }
    }
    public void Combat()
    {
        var random = new Random();
        Console.WriteLine("After nearing it's hiding place an Alien footsoldier jumps out to attack you!");
        List<int> damages = GetEnemies();
        int enemyHP = 50;
        int playerHP = p.GetPlayerHP();
        bool dead = false;
        bool defeated = false;
        do
        {
            int enemyDamage = damages[random.Next(damages.Count())];
            int hit = p.Attack();
            enemyHP -= hit;
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine($"You hit the enemy for {hit} damage.");
            if (enemyHP <= 0){
                defeated = true;
                Console.WriteLine("You have killed the alien.");
            }
            if (!defeated){
                playerHP -= enemyDamage;
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.WriteLine($"You have been hit for {enemyDamage}");
                if (playerHP <= 0){
                    dead = true;
                    Console.WriteLine("You have died.");
                    break;
                };
            }
        } while (dead == false || defeated == false);
    }
}