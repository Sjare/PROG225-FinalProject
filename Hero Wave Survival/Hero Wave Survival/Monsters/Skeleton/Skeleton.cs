using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Skeleton
{
    public class Skeleton : BaseMonster
    {
        private BaseHero hero;
        private SAvatar tmp;
        private Timer attackTimer;
        private Random _speedDiff = new Random();

        public Skeleton(BaseHero hero)
        {
            this.hero = hero;

            Health = 50;
            Armor = 1;
            Speed = _speedDiff.Next(1, 4);
            HighEndDamage = 26;
            LowEndDamage = 15;
            EXP = 1;
            Dodge = 6;
            Worth = 1;
            Accuracy = 0;

            tmp = new SAvatar(Health);
            tmp.Portrait.Click += Portrait_Click;
            tmp.Health.Click += Portrait_Click;

            Avatar = tmp;

            attackTimer = new Timer();
            attackTimer.Interval = Speed * 1000;
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                //TODO: come and think of debuff for a skeleton to apply
            }
        }

        private void Portrait_Click(object sender, EventArgs e)
        {
            hero.Attack(this);
            tmp.UpdateHealth(Health);
        }

        public override void Kill()
        {
            attackTimer.Stop();
        }
    }
}
