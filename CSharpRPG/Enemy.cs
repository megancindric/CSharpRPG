using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Enemy : Character
    {
        internal Enemy(string characterName)
            :base(characterName)
            {
            }

        internal void EnemyAttack(Hero hero)
        {
            hero.health -= attackPower;
            hero.health = hero.health < 0 ? 0 : hero.health;

            Console.WriteLine($"\n{name} attacks {hero.name} and deals {attackPower} damage!\n{hero.name} has {hero.health} health remaining!\n");
        }
    }
}
