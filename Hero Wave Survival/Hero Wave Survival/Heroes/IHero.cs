using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int Damage { get; set; }
        int Dodge { get; set; }
        int Gold { get; set; }
        int Accuracy { get; set; }

        bool isAlive { get;}

        void TakeDamage(int damage);
        bool Attack(IMonster monster);
        void LevelUp();
    }
}
