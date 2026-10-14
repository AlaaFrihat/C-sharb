using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day_6
{
    internal class Warrior : GameCharacter
    {
        public Warrior(string name , int health) : base ( name , health ) { }
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");

      
        }
        public override void TakeDamage(int amount)
        {
          
            amount -= 2;
        }

    }
}
