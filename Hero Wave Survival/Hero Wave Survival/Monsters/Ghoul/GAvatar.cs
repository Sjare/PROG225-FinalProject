using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Ghoul
{
    public partial class GAvatar : UserControl
    {
        public PictureBox Portrait { get => pbPortrait; }
        public ProgressBar Health { get => pgbHealth; }

        public GAvatar(int health)
        {
            InitializeComponent();

            pgbHealth.Maximum = health;
            pgbHealth.Value = health;
        }

        public void UpdateHealth(int health)
        {
            pgbHealth.Value = health;
        }

        public void DeadAvatar()
        {
            pbPortrait.Image = new Bitmap("CorpsePile.png");
        }
    }
}
