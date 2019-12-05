using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Heroes;
using Hero_Wave_Survival.Monsters.Zombie;

namespace Hero_Wave_Survival.Monsters
{
    public class BaseMonster : IMonster
    {
        private int _health;
        private int _armor;
        private int _speed;
        private int _highEndDam;
        private int _lowEndDam;
        private int _dodge;
        private int _exp;
        private int _worth;
        private int _acc;

        private bool _isAlive = true;

        private UserControl _avatar;

        public int Health { get { return _health; } set { _health = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Dodge { get { return _dodge; } set { _dodge = value; } }
        public int EXP { get { return _exp; } set { _exp = value; } }
        public int Worth { get { return _worth; } set { _worth = value; } }
        public int Accuracy { get { return _acc; } set { _acc = value; } }
        public int HighEndDamage { get { return _highEndDam; } set { _highEndDam = value; } }
        public int LowEndDamage { get { return _lowEndDam; } set { _lowEndDam = value; } }
        public bool HasBeenCounted { get; set; }

        public UserControl Avatar { get { return _avatar;} set { _avatar = value; } }

        public bool isAlive { get { return _isAlive; } }

        Random chanceToHit = new Random();
        Random damageCalc = new Random();

        public BaseMonster()
        {

        }

        public bool Attack(IHero hero)
        {
            int damage = damageCalc.Next(_lowEndDam, _highEndDam);
            int hitChance = (chanceToHit.Next(1, 20) + _acc);

            if (hitChance > hero.Dodge)
            {
                hero.TakeDamage(damage);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeDamage(int damage)
        {
            int trueDamage = damage -= _armor;

            _health -= trueDamage;

            if (_health <= 0)
            {
                _health = 0;
                _isAlive = false;
            }
        }

        public virtual void Kill()
        {
            
        }
    }
}
