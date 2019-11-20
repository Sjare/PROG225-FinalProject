using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Heroes.Warrior
{
    class Warrior : BaseHero
    {
        public Warrior(string name)
        {
            Health = 100;
            Armor = 10;
            Speed = 5;
            Damage = 25;
            EXP = 0;
            Dodge = 5;
            Name = name;
            Gold = 0;
            Avatar = new WAvatar(Name, Health, Level, Armor, Dodge, Speed, Gold, EXP, Accuracy, Damage);
        }
    }
}
