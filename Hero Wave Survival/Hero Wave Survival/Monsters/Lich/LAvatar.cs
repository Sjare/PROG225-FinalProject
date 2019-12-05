using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Monsters.Lich
{
    public partial class LAvatar : UserControl
    {
        public PictureBox Portrait { get => pbPortrait; set => pbPortrait = value; }
        public ProgressBar Health { get => pbHealth;  }

        public LAvatar(int health)
        {
            InitializeComponent();
            pbHealth.Maximum = health;
            pbHealth.Value = health;
        }

        public void UpdateHealth(int health)
        {
            pbHealth.Value = health;
        }
    }
}
