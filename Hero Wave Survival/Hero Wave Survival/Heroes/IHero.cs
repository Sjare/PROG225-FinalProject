using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Items;
using Hero_Wave_Survival.Monsters;

namespace Hero_Wave_Survival.Heroes
{
    public interface IHero
    {
        string Name { get; set; }

        int Health { get; set; }
        int Level { get; set; }
        int EXP { get; set; }
        int Armor { get; set; }
        int Speed { get; set; }
        int HighEndDamage { get; set; }
        int LowEndDamage { get; set; }
        int Dodge { get; set; }
        int Gold { get; set; }
        int Accuracy { get; set; }

        UserControl Avatar { get; set; }

        List<IItem> Backpack { get; }

        bool isAlive { get;}

        void TakeDamage(int damage);
        bool Attack(IMonster monster);
        void LevelUp();
    }
}
