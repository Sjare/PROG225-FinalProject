using Hero_Wave_Survival.Heroes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Ghoul
{
    public class Ghoul : BaseMonster
    {
        private GAvatar tmp;
        private BaseHero hero;
        private Debuff _maim;
        private Random _speedDiff = new Random();
        private Timer attackTimer;

        public Ghoul(BaseHero Hero)
        {
            Health = 50;
            Armor = 1;
            Speed = _speedDiff.Next(4, 7);
            HighEndDamage = 36;
            LowEndDamage = 10;
            EXP = 2;
            Dodge = 4;
            Worth = 2;
            Accuracy = 1;

            tmp = new GAvatar(this.Health);
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

        private void Portrait_Click(object sender, EventArgs e)
        {
            hero.Attack(this);
            tmp.UpdateHealth(Health);
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            if (Attack(hero))
            {
                _maim = new Debuff();
                _maim.Stat = "Maim";
                _maim.Value = 2;
                hero.ApplyDebuff(_maim);
            }
        }

        public override void Kill()
        {
            attackTimer.Stop();
            tmp.Portrait.Image = new Bitmap("CorpsePile.png");
            System.Media.SoundPlayer deathSound = new System.Media.SoundPlayer("GhoulDeath.wav");
            deathSound.Play();
        }
    }
}
