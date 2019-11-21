using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added folders
using Hero_Wave_Survival;
using Hero_Wave_Survival.Heroes.Warrior;
using Microsoft.VisualBasic;
using Hero_Wave_Survival.GameScreens;

namespace Hero_Wave_Survival.GameScreens
{
    public partial class HeroPicker : Form
    {
        public HeroPicker()
        {
            InitializeComponent();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            string nameInput = Interaction.InputBox("Hero Name Input");

            Warrior warrior = new Warrior(nameInput);

            Arena arena = new Arena(warrior);

            arena.Show();

            this.Close();
        }
    }
}
