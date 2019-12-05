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
        MainMenu mw;

        public Arena(BaseHero baseHero, MainMenu MW)
        {
            InitializeComponent();

            hero = baseHero;

            tbArena.Controls.Add(hero.Avatar);

            hero.Avatar.Dock = DockStyle.Fill;

            mw = MW;

            Controller = new GameController(hero,this,mw);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Controller.WaveSpawner();
            btnStart.Visible = false;
            this.Controls.Remove(btnStart);
        }

        private void BtnNextWave_Click(object sender, EventArgs e)
        {
            Controller.WaveSpawner();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            StoreFront storeFront = new StoreFront(this.hero);
            storeFront.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to quit? Progress will not be saved!","Quit",
            MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //do nothing
            }
            else
            {
                mw.Show();
                this.Close();
            }

            //TODO: maybe come back and implement a save feature
        }
    }
}