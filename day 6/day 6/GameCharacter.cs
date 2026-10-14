using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System;

namespace day_6
{
    abstract class GameCharacter
    {
        private int _health;

        public string Name { get; set; }

        public GameCharacter(string name, int Health)
        {
            Name = name;
            health = Health;
        }

        public int health
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = 0;
                }
            }
            get
            {
                return _health;
            }
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            health -= amount;
        }

        public void Heal()
        {
            health += 10;
        }

        public void Heal(int amount)
        {
            health += amount;
        }
    }
}








