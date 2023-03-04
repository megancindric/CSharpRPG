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
            Console.WriteLine($"\n\n{hero.name} must defeat {enemyList.fighters.Count} enemies to win!\n\n");
        }

        internal void ExecuteBattle()
        {
            while (enemyList.fighters.Count > 0 && hero.health > 0)
            {
                //Zag attack fighter method
                hero.HeroAttack(enemyList.fighters[0]);
                DeathCheck(enemyList.fighters[0]);
          
                //Fighter attack Zag method
                if (enemyList.fighters.Count > 0)
                {
                    enemyList.fighters[0].EnemyAttack(hero);
                }

            }
        }

        public void DeathCheck(Enemy fighter)
        {
            if (fighter.health == 0){
                Console.WriteLine($"{fighter.name} has been defeated!");
                enemyList.fighters.Remove(fighter);
                Console.ReadLine();
            }
        }


        internal void DisplayWinner()
        {
            if (enemyList.fighters.Count> 0)
            {
                Console.WriteLine($"{hero.name} has fallen!  Better luck next time!");
            }
            else
            {
                Console.WriteLine($"{hero.name} has emerged victorious!!");
            }

            Console.ReadLine();
        }
    }
}
