using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Monsters
{
    public interface IMonster
    {
        int Health { get; set; }
        int Armor { get; set; }
        int Speed { get; set; }
        int Damage { get; set; }
        int Dodge { get; set; }
        int EXP { get; set; }
        int Worth { get; set; }
        int Accuracy { get; set; }
        
        bool isAlive { get; }

        void TakeDamage(int damage);
        void Attack(IHero hero);
    }
}
