﻿using System;
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

        public Arena(BaseHero baseHero)
        {
            InitializeComponent();

            hero = baseHero;

            tbArena.Controls.Add(hero.Avatar);

            hero.Avatar.Dock = DockStyle.Fill;

            Controller = new GameController(hero,this);


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

        }
    }
}