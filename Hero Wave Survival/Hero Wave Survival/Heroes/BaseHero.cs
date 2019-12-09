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
    public class BaseHero : IHero
    {
        private UserControl _avatar;
        private Stack<IItem> _backpack = new Stack<IItem>();
        private List<Debuff> debuffs = new List<Debuff>();
        private string _name;
        private int _health;
        private int _level;
        private int _armor;
        private int _speed;
        private int _highEndDam;
        private int _lowEndDam;
        private int _dodge;
        private int _gold;
        private int _exp;
        private int _acc;
        private int _maxHealth;
        private int _maxArmor;
        private int _maxDodge;
        private int _maxAcc;
        private int _speedBuffer;
        private bool _canAttack = true;
        private bool _isAlive = true;
        private bool _canUseSpecial = true;

        public string Name { get { return _name; } set { _name = value; } }
        public int Health { get => _health; set => _health = value; }
        public int Level { get { return _level; } set { _level = value; } }
        public int Armor { get => _armor; set => _armor = value; }
        public int Speed { get { return _speed; } set { _speed = value; } }
        public int Dodge { get { return _dodge; } set { _dodge = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int EXP { get { return _exp; } set { _exp = value; } }
        public int Accuracy { get { return _acc; } set { _acc = value; } }
        public int HighEndDamage { get { return _highEndDam; } set { _highEndDam = value; } }
        public int LowEndDamage { get { return _lowEndDam; } set { _lowEndDam = value; } }
        public int MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int MaxArmor { get => _maxArmor; set => _maxArmor = value; }
        public int MaxDodge { get => _maxDodge; set => _maxDodge = value; }
        public int MaxAcc { get => _maxAcc; set => _maxAcc = value; }
        public bool isAlive { get { return _isAlive; } }
        public bool CanUseSpecial
        {
            get { return _canUseSpecial; }
            set { _canUseSpecial = value; }
        }

        public Random DamageCalc { get => damageCalc; }
        public UserControl Avatar { get { return _avatar; } set { _avatar = value; } }
        public Stack<IItem> Backpack { get { return _backpack; } }

        private Timer attackTimer;
        private Timer checkDebuffs;
        private Timer specialCooldown;

        Random chanceToHit = new Random();
        Random damageCalc = new Random();

        public BaseHero()
        {

        }

        protected void setTimer()
        {
            attackTimer = new Timer();
            attackTimer.Interval = _speed * 1000; //turns speed into seconds for timer
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;

            checkDebuffs = new Timer();
            checkDebuffs.Interval = 1;
            checkDebuffs.Enabled = true;
            checkDebuffs.Tick += CheckDebuffs_Tick;

            specialCooldown = new Timer();
            specialCooldown.Interval = 3000;
            specialCooldown.Enabled = true;
            specialCooldown.Tick += SpecialCooldown_Tick;
        }

        private void SpecialCooldown_Tick(object sender, EventArgs e)
        {
            _canUseSpecial = true;
        }

        private void CheckDebuffs_Tick(object sender, EventArgs e)
        {
            CheckDebuffs();
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            _canAttack = true;
        }

        public bool Attack(IMonster monster)
        {
            int damage = damageCalc.Next(_lowEndDam, _highEndDam);
            int hitChance = (chanceToHit.Next(1, 21) + _acc);

            if (_canAttack)
            {
                if (hitChance > monster.Dodge)
                {
                    System.Media.SoundPlayer hitSound = new System.Media.SoundPlayer("AttackHit.wav");
                    hitSound.Play();
                    monster.TakeDamage(damage);
                    _canAttack = false;

                    if (!monster.isAlive)
                    {
                        monster.Kill();
                        _exp += monster.EXP;
                        _gold += monster.Worth;

                        if (_exp == 5)
                        {
                            LevelUp();
                        }
                    }

                    updateAvatar();
                    return true;
                }
                else
                {
                    return false;
                }
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

            updateAvatar();
        }

        public void LevelUp()
        {
            _maxHealth += 5;
            _health = _maxHealth;
            _highEndDam += 1;
            _level++;
            _lowEndDam += 1;
            _dodge += 1;
            _speed += 1;
            _exp = 0;
        }

        public virtual void updateAvatar()
        {
            //overridden by hero classes
        }

        public virtual void specialAttack(IMonster monster)
        {
            //overridden by hero classes
        }

        public void Heal()
        {
            if (Backpack.Count != 0)
            {
                HealthPotion buffer = (HealthPotion)Backpack.Pop();

                _health += buffer.RestoreHP;

                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }

                System.Media.SoundPlayer healingPot = new System.Media.SoundPlayer("HealingPot.wav");
                healingPot.Play();

                updateAvatar();
            }

            //TODO: Come back and spit an error out if backpack is empty
        }

        private void Kill()
        {
            attackTimer.Stop();
        }

        public void ApplyDebuff(Debuff debuff) //applying my debuff when hit
        {
            bool doesExist = false;

            if(debuffs.Count > 0)
            {
                foreach(Debuff dbuff in debuffs)
                {
                    if (dbuff.Stat == debuff.Stat)
                    {
                         doesExist = true;
                    }
                }

                if (!doesExist)
                {
                    debuffs.Add(debuff);

                    if (debuff.Stat == "Rot")
                    {
                        _armor -= debuff.Value;
                    }
                    else if (debuff.Stat == "BoneDust")
                    {
                        _acc -= debuff.Value;
                    }
                    else if(debuff.Stat == "Chill")
                    {
                        _speedBuffer = _speed;
                        _speed -= debuff.Value;
                        attackTimer.Interval = _speed * 1000;
                    }
                }
            }
            else
            {
                debuffs.Add(debuff);

                if (debuff.Stat == "Rot")
                {
                    _armor -= debuff.Value;
                }
                else if(debuff.Stat == "BoneDust")
                {
                    _acc -= debuff.Value;
                }
            }

            updateAvatar();
        }

        private void CheckDebuffs() //remove debuff code
        {
            List<Debuff> tmp = new List<Debuff>();

            foreach (Debuff debuff in debuffs)
            {
                //removing debuff
                if (Math.Abs((debuff.timestamp - DateTime.Now).Seconds) >= 5)
                {
                    tmp.Add(debuff);

                    if(debuff.Stat == "Rot")
                    {
                        _armor = _maxArmor;
                    }
                    else if(debuff.Stat == "BoneDust")
                    {
                        _acc = _maxAcc;
                    }
                    else if(debuff.Stat == "Chill")
                    {
                        _speed = _speedBuffer;

                        attackTimer.Interval = _speed * 1000;
                    }
                }
            }
            foreach (Debuff debuff in tmp)
            {
                debuffs.Remove(debuff);
            }

            updateAvatar();
        }
    }
}
