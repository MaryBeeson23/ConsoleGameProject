using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Repository
{
public abstract class LivingCreature {   
    public LivingCreature()
    {
        
    }
public LivingCreature(int maxHP, int currentHP)
{
    MaxHP = maxHP;
    CurrentHP = currentHP;
}
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
    }
}

