using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Lich
{
    public class Lich : BaseMonster
    {
        private Random _speedDiff = new Random();
        private BaseHero hero;
        private LAvatar tmp;
        private Debuff FrostChill;
        public Timer attackTimer;

        public Lich(BaseHero Hero)
        {
            Health = 80;
            Armor = 5;
            Speed = _speedDiff.Next(2, 5);
            HighEndDamage = 36;
            LowEndDamage = 25;
            EXP = 1;
            Dodge = 4;
            Worth = 500;
            Accuracy = 0;

            tmp = new LAvatar(this.Health);
            tmp.Portrait.MouseClick += Portrait_MouseClick;
            tmp.Health.MouseClick += Portrait_MouseClick;

            Avatar = null;
            Avatar = tmp;

            attackTimer = new Timer();
            attackTimer.Interval = Speed * 1000;
            attackTimer.Enabled = true;
            attackTimer.Tick += AttackTimer_Tick;

            hero = Hero;
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                FrostChill = new Debuff();
                FrostChill.Stat = "Chill";
                FrostChill.Value = 2;
                hero.ApplyDebuff(FrostChill);
            }
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

        public override void Kill()
        {
            attackTimer.Stop();
            tmp.Portrait.Image = new Bitmap("CorpsePile.png");
        }
    }
}
