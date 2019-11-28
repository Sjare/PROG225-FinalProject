using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Skeleton
{
    public partial class SAvatar : UserControl
    {
        public PictureBox Portrait
        {
            get { return pbAvatar; }
        }
        public ProgressBar Health
        {
            get { return prbHealth; }
        }

        public SAvatar(int health)
        {
            InitializeComponent();

            prbHealth.Maximum = health;
            prbHealth.Value = health;
        }

        public void UpdateHealth(int health)
        {
            prbHealth.Value = health;
        }
    }
}
