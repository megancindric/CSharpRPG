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
        }
        internal void GreetUser()
        {
            Console.WriteLine("\n\n========== WELCOME TO THE THUNDERDOME ==========\n\n");
            Console.WriteLine($"\n\n{hero.name} must defeat three enemies to win!\n\n");
        }
    }
}
