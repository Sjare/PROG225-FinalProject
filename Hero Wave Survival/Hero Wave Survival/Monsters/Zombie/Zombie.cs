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
            HighEndDamage = 16;
            LowEndDamage = 5;
            EXP = 1;
            Dodge = 4;
            Worth = 1;
            Accuracy = 0; 

            tmp = new ZAvatar(this.Health);

            tmp.Portait.MouseClick += Portait_MouseClick;
            tmp.Health.MouseClick += Portait_MouseClick;

            Avatar = null;
            Avatar = tmp;

            attackTimer = new Timer();
            attackTimer.Interval = Speed * 1000;
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;
            hero = Hero;
        }

        private void Portait_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                hero.specialAttack(this);
                tmp.updateHealth(Health);
            }
            else if (e.Button == MouseButtons.Left)
            {
                hero.Attack(this);
                tmp.updateHealth(Health);
            }
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                Rot = new Debuff();
                Rot.Stat = "Rot";
                Rot.Value = 1;
                hero.ApplyDebuff(Rot);
            }
        }

        public override void Kill()
        {
            attackTimer.Stop();
            tmp.Portait.Image = new Bitmap("CorpsePile.png");
            System.Media.SoundPlayer deathSound = new System.Media.SoundPlayer("ZombieDeath.wav");
            deathSound.Play();
        }
    }
}
