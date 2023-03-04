﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRPG
{
    internal abstract class Character
    {
        internal string name;
        internal int health;
        // new() abbreviates new List<string>();
        // internal List<string> attackNames = new();
        internal int attackPower;
        internal Random random = new Random();
        internal Character(string characterName)
        {
            this.name = characterName;
            this.health = 100;
            this.attackPower = random.Next(20,30);

        }

        
        

        
    }

    
}