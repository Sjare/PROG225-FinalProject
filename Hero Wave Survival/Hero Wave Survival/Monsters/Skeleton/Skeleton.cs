using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Skeleton
{
    public class Skeleton : BaseMonster
    {
        //private objects
        private BaseHero hero;
        private SAvatar tmp;
        private Timer attackTimer;
        private Random _speedDiff = new Random();
        private Debuff BoneDust;

        public Skeleton(BaseHero hero)
        {
            this.hero = hero;

            Health = 50;
            Armor = 1;
            Speed = _speedDiff.Next(1, 4);
            HighEndDamage = 21;
            LowEndDamage = 10;
            EXP = 1;
            Dodge = 6;
            Worth = 1;
            Accuracy = 0;

            tmp = new SAvatar(Health);
            tmp.Portrait.MouseClick += Portrait_MouseClick;
            tmp.Health.MouseClick += Portrait_MouseClick;

            Avatar = tmp;

            attackTimer = new Timer();
            attackTimer.Interval = Speed * 1000;
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;
        }

        private void Portrait_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                hero.specialAttack(this);
                tmp.UpdateHealth(Health);
            }
            else if (e.Button == MouseButtons.Left)
            {
                hero.Attack(this);
                tmp.UpdateHealth(Health);
            }
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                BoneDust = new Debuff();
                BoneDust.Stat = "BoneDust";
                BoneDust.Value = 1;
                hero.ApplyDebuff(BoneDust);
            }
        }

        public override void Kill()
        {
            attackTimer.Stop();
            tmp.Portrait.Image = new Bitmap("CorpsePile.png");
            System.Media.SoundPlayer deathSound = new System.Media.SoundPlayer("SkeletonDeath.wav");
            deathSound.Play();
        }
    }
}
