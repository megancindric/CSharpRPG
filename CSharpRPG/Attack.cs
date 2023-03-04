using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal class Attack
    {

        internal string attackName;
        internal int attackPower;

        internal Attack(string attackName, int attackPower)
        {
            this.attackName = attackName;
            this.attackPower = attackPower;

        }
    }
}
