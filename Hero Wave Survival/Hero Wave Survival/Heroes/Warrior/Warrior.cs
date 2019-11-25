using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Heroes.Warrior
{
    class Warrior : BaseHero
    {
        WAvatar tmp;

        public Warrior(string name)
        {
            Health = 100;
            Armor = 10;
            Speed = 2;
            Damage = 25;
            EXP = 0;
            Dodge = 5;
            Name = name;
            Gold = 0;
            Accuracy = 50;
            tmp = new WAvatar(Name, Health, Level, Armor, Dodge, Speed, Gold, EXP, Accuracy, Damage);
            Avatar = tmp;
            setTimer();
        }

        public override void updateAvatar()
        {
            tmp.updateAvatar(Health, Level, Armor, Dodge, Speed, Gold, EXP, Accuracy, Damage);
        }
    }
}
