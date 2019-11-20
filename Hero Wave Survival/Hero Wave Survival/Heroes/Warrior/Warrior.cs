using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Heroes.Warrior
{
    class Warrior : BaseHero
    {
        public Warrior()
        {
            Health = 100;
            Armor = 10;
            Speed = 5;
            Damage = 25;
            EXP = 0;
            Dodge = 5;
        }
    }
}
