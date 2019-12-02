using Hero_Wave_Survival.Items;
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
            MaxHealth = 100;
            Health = MaxHealth;
            MaxArmor = 10;
            Armor = MaxArmor;
            Speed = 3;
            HighEndDamage = 26;
            LowEndDamage = 15;
            EXP = 0;
            MaxDodge = 5;
            Dodge = MaxDodge;
            Name = name;
            Gold = 0;
            MaxAcc = 1;
            Accuracy = MaxAcc;

            Backpack.Push(new HealthPotion());

            tmp = new WAvatar(Name, Health, Level, Armor, Dodge, Speed, Gold, EXP, Accuracy, ((HighEndDamage+LowEndDamage)/2), Backpack);
            tmp.btnUseHP.Click += BtnUseHP_Click;

            Avatar = tmp;

            setTimer();
        }

        private void BtnUseHP_Click(object sender, EventArgs e)
        {
            if(Health < 100)
            {
                Heal();
            }

            //TODO: Add error when hero is already full hp
        }

        public override void updateAvatar()
        {
            tmp.updateAvatar(Health, Level, Armor, Dodge, Speed, Gold, EXP, Accuracy, ((HighEndDamage + LowEndDamage) / 2), Backpack);
        }
    }
}
