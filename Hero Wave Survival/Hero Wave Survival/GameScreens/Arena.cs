using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Game_Controller;
using Hero_Wave_Survival.Heroes;
using Hero_Wave_Survival.Monsters;

namespace Hero_Wave_Survival.GameScreens
{
    public partial class Arena : Form
    {
        BaseHero hero;

        GameController Controller;

        private List<BaseMonster> monsters = new List<BaseMonster>();

        public Arena(BaseHero baseHero)
        {
            InitializeComponent();

            hero = baseHero;

            tbArena.Controls.Add(hero.Avatar);

            hero.Avatar.Dock = DockStyle.Fill;

            Controller = new GameController(hero);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            monsters = Controller.WaveSpawner();

            foreach(BaseMonster monster in monsters)
            {
                tbEnem.Controls.Add(monster.Avatar);
                monster.Avatar.Dock = DockStyle.Fill;
            }

            btnStart.Visible = false;
        }
    }
}
