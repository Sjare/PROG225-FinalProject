using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Monsters;

namespace Hero_Wave_Survival.Heroes
{
    public class BaseHero : IHero
    {
        private UserControl _avatar;

        private string _name;

        private int _health;
        private int _level;
        private int _armor;
        private int _speed;
        private int _damage;
        private int _dodge;
        private int _gold;
        private int _exp;
        private int _acc;

        private bool _isAlive = true;

        public string Name { get { return _name; } set { _name = value; } }

        public int Health { get { return _health; } set { _health = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int Dodge { get { return _dodge; } set { _dodge = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int EXP { get { return _exp; }set { _exp = value; } }
        public int Accuracy { get { return _acc; } set { _acc = value; } }

        public bool isAlive { get { return _isAlive; }}

        public UserControl Avatar { get { return _avatar; } set { _avatar = value; } }

        Random chanceToHit = new Random();

        public BaseHero()
        {

        }

        public bool Attack(IMonster monster)
        {
            if(chanceToHit.Next(1,_acc) > monster.Dodge)
            {
                monster.TakeDamage(_damage);

                if (!monster.isAlive)
                {
                    _exp += monster.EXP;

                    if (_exp == 5)
                    {
                        LevelUp();
                    }
                }

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

            if(_health <= 0)
            {
                _health = 0;
                _isAlive = false;
            }
        }

        public void LevelUp()
        {
            _health += 5;
            _damage += 1;
            _dodge += 1;
            _speed += 1;
            _exp = 0;
        }
    }
}
