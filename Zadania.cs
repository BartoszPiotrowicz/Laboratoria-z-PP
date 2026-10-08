// Zad 1

//using System;

//class program
//{
//    static void Main()
//    {
//        string name = "Vox";
//        char symbol = '@';
//        int level = 2;
//        int gold = 35;
//        double weight = 3.0;
//        bool has_map = true;

//        Console.WriteLine("===RAPORT===");
//        Console.WriteLine("Name: " + name + " (string)");
//        Console.WriteLine("Symbol: " + symbol + " (char)");
//        Console.WriteLine("Level: " + level + " (int)");
//        Console.WriteLine("Gold: " + gold + " (int)");
//        Console.WriteLine("Weight: " + weight + " (double)");
//        Console.WriteLine("Has map?: " + has_map + " (bool)");

//        level = 21;
//        gold = 37;

//        Console.WriteLine("===RAPORT===");
//        Console.WriteLine("Name: " + name + " (string)");
//        Console.WriteLine("Symbol: " + symbol + " (char)");
//        Console.WriteLine("Level: " + level + " (int)");
//        Console.WriteLine("Gold: " + gold + " (int)");
//        Console.WriteLine("Weight: " + weight + " (double)");
//        Console.WriteLine("Has map?: " + has_map + " (bool)");
//    }
//}

// Zad 2
//using System;

//class program
//{
//    static void Main()
//    {
//        int gold = 8;
//        int exp = 0;
//        int training = 0;

//        Console.WriteLine("===RAPORT===");
//        Console.WriteLine("Gold: " + gold + " (int)");
//        Console.WriteLine("Exp: " + exp + " (int)");
//        Console.WriteLine("Training: " + training + " (int)");

//        exp += 25;
//        exp *= 2;
//        gold -= 8;
//        gold += 15;
//        training++;

//        Console.WriteLine("===RAPORT===");
//        Console.WriteLine("Gold: " + gold + " (int)");
//        Console.WriteLine("Exp: " + exp + " (int)");
//        Console.WriteLine("Training: " + training + " (int)");
//    }
//}

// Zad 3
//using System;

//class program
//{
//    static void Main()
//    {
//        int rations;
//        int team_memb;
//        int time;

//        rations = int.Parse(Console.ReadLine());
//        team_memb = int.Parse(Console.ReadLine());
//        time = int.Parse(Console.ReadLine());

//        Console.WriteLine("Rations: " + rations);
//        Console.WriteLine("Team member count: " + team_memb);
//        Console.WriteLine("Expedition time: " + time);

//        Console.WriteLine("Full Rations: " + rations / team_memb);
//        Console.WriteLine("Leftover Rations: " + rations % team_memb);
//        Console.WriteLine("Rations per day: " + (double)rations / 5);
//        Console.WriteLine("Avg rations per day : " + (double)rations / team_memb / 5);
//    }
//}

// Zad 4
//using System;

//class program
//{
//    static void Main()
//    {
//        int hp = 100;
//        int potion_count = 0;
//        bool has_key = false;
//        bool has_map = false;

//        hp = int.Parse(Console.ReadLine());
//        potion_count = int.Parse(Console.ReadLine());
//        has_key = bool.Parse(Console.ReadLine());
//        has_map = bool.Parse(Console.ReadLine());

//        bool is_alive = hp != 0;
//        bool has_full_health = hp == 100;
//        bool has_equip = potion_count != 0;
//        bool has_nav = has_map || has_key; ;
//        bool ready = is_alive && has_equip && has_nav;
//        bool requires_heal = !has_full_health;

//        Console.WriteLine("Is alive: " + is_alive);
//        Console.WriteLine("Has full health: " + has_full_health);
//        Console.WriteLine("Needs healing: " + requires_heal);
//        Console.WriteLine("Has equipment : " + has_equip);
//        Console.WriteLine("Has key or map: " + has_nav);
//        Console.WriteLine("Ready for adventure: " + ready);
//    }
//}

// Zad 5
using System;

class program
{
    static void Main()
    {
        string name = "Vox";
        int max_hp = 150;
        int current_hp = 12;
        int base_dmg = 10;
        int damage_boost = 5;
        double special_attack = 2.0;
        int attack_count = 5;

        name = Console.ReadLine();
        max_hp = int.Parse(Console.ReadLine());
        current_hp = int.Parse(Console.ReadLine());
        base_dmg = int.Parse(Console.ReadLine());
        damage_boost = int.Parse(Console.ReadLine());
        special_attack = double.Parse(Console.ReadLine());
        attack_count = int.Parse(Console.ReadLine());

        int regular_dmg = base_dmg + damage_boost;
        double special_dmg = regular_dmg * special_attack;
        int total_damage = regular_dmg * attack_count + (int)special_dmg;
        double remaining_hp = (double)current_hp / max_hp * 100;
        bool is_alive = current_hp != 0;
        bool has_full_health = current_hp == max_hp;

        Console.WriteLine("===BATTLE REPORT===");
        Console.WriteLine("Hero: " + name);
        Console.WriteLine("Health: " + current_hp + "/" + max_hp + "(" + remaining_hp + "%" + ")");
        Console.WriteLine("Base attack: " + base_dmg);
        Console.WriteLine("Special attack : " + (int)special_dmg);
        Console.WriteLine("Total damage: " + total_damage);
        Console.WriteLine("Is alive: " + is_alive);
        Console.WriteLine("Has full health: " + has_full_health);
        Console.WriteLine("===================");
    }
}

// Zad 6