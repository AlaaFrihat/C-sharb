using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior("Ala`a", 75);
            Wizard wa1 = new Wizard("Ali",60);
            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(w1);
            characters.Add(wa1);
            foreach (GameCharacter player in characters)
            {
                player.UseSpecialAbility();
            }
            foreach (GameCharacter player in characters) {
                player.TakeDamage(20);
                Console.WriteLine($"health after take damage :,{player.Name},{player.health}");
            }
            w1.Heal();
            wa1.Heal();
            Console.WriteLine($"{w1.Name} health after heal: {w1.health}");
            Console.WriteLine($"{wa1.Name} health after heal: {wa1.health}");

            HealthPotion hp = new HealthPotion();
            hp.PotionName = "kingPotion";
            hp.Collect();
            hp.Use(wa1, "25");
            Console.WriteLine($"{wa1.Name} health after potion: {wa1.health}");

            hp.Use(w1, "abc");
            
        }
    }
}
