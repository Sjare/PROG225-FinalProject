using Hero_Wave_Survival.GameScreens;
using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Zombie
{
    public class Zombie : BaseMonster
    {
        private Random _speedDiff = new Random();
        private BaseHero hero;
        private ZAvatar tmp;
        private Debuff Rot;
        public Timer attackTimer;

        public Zombie(BaseHero Hero)
        {
            Health = 30;
            Armor = 0;
            Speed = _speedDiff.Next(2,5);
            HighEndDamage = 21;
            LowEndDamage = 10;
            EXP = 1;
            Dodge = 4;
            Worth = 1;
            Accuracy = 0; 

            tmp = new ZAvatar(this.Health);
            tmp.Portait.Click += Portait_Click;
            tmp.Health.Click += Portait_Click;

            Avatar = null;
            Avatar = tmp;

            attackTimer = new Timer();
            attackTimer.Interval = Speed * 1000;
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;

            Rot = new Debuff();
            Rot.Stat = "Rot";
            Rot.Value = 1;

            hero = Hero;
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                hero.ApplyDebuff(Rot);
            }
        }

        private void Portait_Click(object sender, EventArgs e)
        {
            hero.Attack(this);
            tmp.updateHealth(Health);
        }

        public override void Kill()
        {
            attackTimer.Stop();
            tmp.Portait.Image = new Bitmap("CorpsePile.png");
        }

        ~Zombie()
        {
            attackTimer.Stop();
        }
    }
}
