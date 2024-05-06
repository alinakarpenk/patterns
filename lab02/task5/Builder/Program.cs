using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeroBuilder heroBuilder = new HeroBuilder();
            Character heroDirector = new Character(heroBuilder);

            // Створення героя
            heroDirector.CreateCharacter(180, "Athletic", "Blonde", "Blue", new List<string> { "Sword", "Shield", "Potion" });
            Hero hero = heroBuilder.Build();
            hero.DisplayInfo();

            Console.WriteLine();

            // Створення будівельника ворога
            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Character enemyDirector = new Character(enemyBuilder);

            // Створення ворога
            enemyDirector.CreateCharacter(170, "Muscular", "Black", "Red", new List<string> { "Staff", "Dark Amulet" });
            Enemy enemy = enemyBuilder.Build();
            enemy.DisplayInfo();

            Console.ReadLine();
        }
    }
}
