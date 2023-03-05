using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Hero : Character
    {
        internal Hero(string characterName)
            :base(characterName)
        {
            AttackPower = random.Next(60, 80);
        }

        public void HeroAttack( Enemy enemy)
        {
            enemy.Health -= AttackPower;

            enemy.Health = enemy.Health < 0 ? 0 : enemy.Health;

            Console.WriteLine($"\n{Name} attacks {enemy.Name} and deals {AttackPower} damage!\n{enemy.Name} has {enemy.Health} health remaining.\n");
        }

    }
}
