using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal abstract class Character
    {
        private string name ="";
        internal string Name { get => name; set => name = value; }
        private int health = 100;
        
        internal int Health
        {
            get => health;
            set => health = value;
        }
        internal AttackArray attackArray = new AttackArray();
        
        // new() abbreviates new List<string>();
        // internal List<string> attackNames = new();
        private int attackPower;
        internal int AttackPower { get => attackPower; set => attackPower = value; }
        internal Random random = new Random();
        internal Character(string characterName)
        {
            Name = characterName;
            AttackPower = random.Next(10,30);
            attackArray.CreateAttackArray(this);
        }

        internal void DisplayCharacterStats()
        {
            Console.WriteLine($"{Name} --  (Attack Power: {AttackPower}, Health: {Health})");
            attackArray.DisplayAttacks();
        }

    }

    
}
