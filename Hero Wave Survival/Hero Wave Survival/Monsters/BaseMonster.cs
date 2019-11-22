using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Heroes;

namespace Hero_Wave_Survival.Monsters
{
    public class BaseMonster : IMonster
    {
        private int _health;
        private int _armor;
        private int _speed;
        private int _damage;
        private int _dodge;
        private int _exp;
        private int _worth;
        private int _acc;

        private bool _isAlive = true;

        public int Health { get { return _health; } set { _health = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int Dodge { get { return _dodge; } set { _dodge = value; } }
        public int EXP { get { return _exp; } set { _exp = value; } }
        public int Worth { get { return _worth; } set { _worth = value; } }
        public int Accuracy { get { return _acc; } set { _acc = value; } }

        public UserControl Avatar { get { return _avatar;} set { _avatar = value; } }

        public bool isAlive { get { return _isAlive; } }

        Random chanceToHit = new Random();

        private UserControl _avatar;

        public BaseMonster()
        {

        }

        public void Attack(IHero hero)
        {
            if(chanceToHit.Next(0,_acc) > hero.Dodge)
            {
                hero.TakeDamage(_damage);
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
    }
}
