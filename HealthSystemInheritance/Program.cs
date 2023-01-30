using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            Console.WriteLine();
            Console.WriteLine("Player:");
            player.ShowHUD();
            player.TakeDamage(15);
            player.ShowHUD();
            player.Heal(5);
            player.ShowHUD();
            player.TakeDamage(150);
            player.ShowHUD();
            player.Heal(5);
            player.ShowHUD();

            Console.WriteLine();
            Console.WriteLine("Enemy:");
            enemy.ShowHUD();
            enemy.TakeDamage(25);
            enemy.ShowHUD();
            enemy.Heal(10);
            enemy.ShowHUD();

            Console.ReadKey(true);
        }
    }
}
