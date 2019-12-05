using Hero_Wave_Survival.Database;
using Hero_Wave_Survival.GameScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival
{
    public partial class MainMenu : Form
    {
        private DBInterface _db;

        public DBInterface Database { get => _db; }

        public MainMenu()
        {
            InitializeComponent();
            _db = new DBInterface();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            HeroPicker heroPicker = new HeroPicker(this);

            heroPicker.Show();

            this.Hide();
        }

        private void BtnScores_Click(object sender, EventArgs e)
        {
            HighscoreScreen highscoreScreen = new HighscoreScreen(this);
            highscoreScreen.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
