using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6
{
    internal class HealthPotion:ICollectible
    {
        public string PotionName { get; set; }

        public void Collect()
        {
            Console.WriteLine("potion is collected");
        }
        public void Use(GameCharacter character, string amountText) {
            try
            {
                int amount = int.Parse(amountText);

                character.Heal(amount);
                Console.WriteLine($"{character.Name} used {PotionName} and healed by {amount} points");
            }
            catch (FormatException)
            {
           
                Console.WriteLine("Error: Invalid input!");
            }

        }
    }
}
