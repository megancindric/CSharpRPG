using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Thunderdome
    {

        internal Hero hero;
        internal EnemyList enemyList;
        internal Thunderdome() {
            hero = new Hero("Zagreus");
            enemyList = new EnemyList();
        }

        internal void RunGame()
        {
            GreetUser();
            ExecuteBattle();
            DisplayWinner();
        }
        internal void GreetUser()
        {
            Console.WriteLine("\n\n========== WELCOME TO THE THUNDERDOME ==========\n\n");
            Console.WriteLine($"{hero.Name} must defeat {enemyList.fighters.Count} enemies to win!\n\n");
            DisplayGameStatus();
        }

        internal void ExecuteBattle()
        {
            while (enemyList.fighters.Count > 0 && hero.Health > 0)
            {
                //Zag attack fighter method
                hero.HeroAttack(enemyList.fighters[0]);
                DeathCheck(enemyList.fighters[0]);
          
                //Fighter attack Zag method
                if (enemyList.fighters.Count > 0)
                {
                    enemyList.fighters[0].EnemyAttack(hero);
                }

                DisplayGameStatus();

            }
        }

        public void DeathCheck(Enemy fighter)
        {
            if (fighter.Health == 0){
                Console.WriteLine($"{fighter.Name} has been defeated!");
                enemyList.fighters.Remove(fighter);
                Console.ReadLine();
            }
        }

        internal void DisplayGameStatus()
        {
            Console.WriteLine("\n========== HERO STATS ==========\n");
            hero.DisplayCharacterStats();

            Console.WriteLine("\n========== Enemy STATS ==========\n");

            for (int i = 0;i < enemyList.fighters.Count;i++)
            {
                enemyList.fighters[i].DisplayCharacterStats();
            }
            Console.ReadLine();
        }

        internal void DisplayWinner()
        {
            if (enemyList.fighters.Count> 0)
            {
                Console.WriteLine($"{hero.Name} has fallen!  Better luck next time!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} has emerged victorious!!");
            }

            Console.ReadLine();
        }
    }
}
