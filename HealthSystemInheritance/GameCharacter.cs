using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemInheritance
{
    internal abstract class GameCharacter
    {
        public int health = 100;
        public int damage = 5;
        public int healthMax = 100;

        public void TakeDamage(int hp)
        {
            Console.WriteLine("About to take " + hp + " damage...");
            health -= hp;
            if (health < 0) health = 0;
        }

        public void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("health = " + health);
            Console.WriteLine("damage = " + damage);
        }

        public void Heal(int heal)
        {
            if (health == 0)
            {
                Console.WriteLine("Player is dead and cannot be healed!");
            }

            else if (health != 0)
            {
                if (health == healthMax)
                {
                    Console.WriteLine("Health is already full!");
                }

                else if (health + heal >= healthMax)
                {
                    Console.WriteLine("Health is restored to full!");
                    health = healthMax;
                }

                else
                {
                    health += heal;
                    Console.WriteLine("Player is healed for " + heal + " points! Health is now " + health + ".");
                }
            }
        }
    }
}
