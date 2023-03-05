using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Attack
    {

        private string attackName = "";
        internal string AttackName { get => attackName; set => attackName = value; }
        private int attackPower;
        internal int AttackPower { get => attackPower; set => attackPower = value; }

        internal Attack(string attackName, int attackPower)
        {
            AttackName = attackName;
            AttackPower = attackPower;

        }
    }
}
