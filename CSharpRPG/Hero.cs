using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Hero : Character
    {
        Random random = new Random();
        internal Hero(string characterName)
            :base(characterName)
        {
            this.attackPower = random.Next(50, 75);

        }

        public void HeroAttack(Hero hero, Enemy enemy)
        {
            enemy.health -= hero.attackPower;

            enemy.health = enemy.health < 0 ? 0 : enemy.health;

            Console.WriteLine($"\n{hero.name} attacks {enemy.name} and deals {hero.attackPower} damage!\n{enemy.name} has {enemy.health} health remaining.\n");
        }

    }
}
