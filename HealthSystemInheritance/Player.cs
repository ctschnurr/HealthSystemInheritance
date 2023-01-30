using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemInheritance
{
    internal class Player : GameCharacter
    {
        public int lives = 3;

        public new void ShowHUD()
        {
            base.ShowHUD();                       
            Console.WriteLine("Lives = " + lives);
        }

        public new void TakeDamage(int hp)
        {
            base.TakeDamage(hp);
            if (health == 0)
            {
                Console.WriteLine("Health is 0, lost one life.");
                lives--;
            }
        }
    }
}
