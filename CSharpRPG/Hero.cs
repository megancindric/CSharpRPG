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
            attackPower = random.Next(50, 75);

        }

        public void HeroAttack( Enemy enemy)
        {
            enemy.health -= attackPower;

            enemy.health = enemy.health < 0 ? 0 : enemy.health;

            Console.WriteLine($"\n{name} attacks {enemy.name} and deals {attackPower} damage!\n{enemy.name} has {enemy.health} health remaining.\n");
        }

    }
}
