using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class AttackArray
    {
        internal Attack[] attackArray;
        private List<string> heroAttackNames = new List<string> {"Pocket Sand", "Cape of Bees", "Void Screams" };
        private List<string> enemyAttackNames = new List<string>() {"Goblin Shenanigans", "Scolding", "Shin Kicking"};
        internal Random random = new Random();
        internal AttackArray()
        {
            attackArray = new Attack[3];
            // Implement strategy design with Enemy vs. Hero generation
        }

        internal void CreateAttackArray(Character character)
        {
            Type tp = character.GetType();
            if (tp.Equals(typeof(Enemy)))
            {
                for (int i = 0; i < enemyAttackNames.Count; i++)
                {
                    Attack newAttack = new Attack(enemyAttackNames[i], random.Next(10,30));
                    attackArray[i] = newAttack;
                }
            }
            else if (tp.Equals(typeof(Hero)))
            {
                for (int i = 0; i < heroAttackNames.Count; i++) {
                    Attack newAttack = new Attack(heroAttackNames[i], random.Next(60, 80));
                    attackArray[i] = newAttack;
                }
            }
        }

        internal void DisplayAttacks()
        {
            for (int i = 0;i < attackArray.Length; i++)
            {
                Console.WriteLine($"\t\tAttack: {attackArray[i].AttackName}   Power: {attackArray[i].AttackPower}");
            }
        }
    }
}
