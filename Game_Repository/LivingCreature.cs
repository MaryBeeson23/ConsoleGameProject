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
public LivingCreature(int MaxHP, int CurrentHP)
{
    this.MaxHP = MaxHP;
    this.CurrentHP = CurrentHP;
}
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
    }
}

