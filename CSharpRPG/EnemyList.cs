using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class EnemyList
    {

        internal List<Enemy> fighters;

        internal EnemyList()
        {
            fighters = new List<Enemy>();
            List<string> enemyNames = new List<string>() { "7-Headed Hydra", "Hades", "Theseus"};
            for (int i = 0; i < enemyNames.Count; i++)
            {
                Enemy enemy = new Enemy(enemyNames[i]);
                fighters.Add(enemy);
            }

        }
    }
}
