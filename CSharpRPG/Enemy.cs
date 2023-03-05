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
            hero.Health -= AttackPower;
            hero.Health = hero.Health < 0 ? 0 : hero.Health;

            Console.WriteLine($"\n{Name} attacks {hero.Name} and deals {AttackPower} damage!\n{hero.Name} has {hero.Health} health remaining!\n");
        }
    }
}
