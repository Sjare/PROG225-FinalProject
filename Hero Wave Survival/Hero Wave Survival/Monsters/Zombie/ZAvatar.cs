﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Zombie
{
    public partial class ZAvatar : UserControl
    {
        public PictureBox Portait { get { return pbZAvatar; } }

        public ProgressBar Health { get { return pbZombieHealth; } }

        public ZAvatar(int Health)
        {
            InitializeComponent();
            pbZombieHealth.Maximum = Health;
            pbZombieHealth.Value = Health;
        }

        public void updateHealth(int health)
        {
            pbZombieHealth.Value = health;
        }

        public void DeadAvatar()
        {
            pbZAvatar.Image = new Bitmap("CorpsePile.png");
        }
    }
}
