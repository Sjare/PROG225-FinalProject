using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Database;

namespace Hero_Wave_Survival.GameScreens
{
    public partial class HighscoreScreen : Form
    {
        private MainMenu mw;

        public HighscoreScreen(MainMenu MW)
        {
            InitializeComponent();

            this.mw = MW;

            dgvScores.DataSource = mw.Database.GetScores();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
