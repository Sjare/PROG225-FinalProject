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
using Microsoft.VisualBasic;

namespace Hero_Wave_Survival.GameScreens
{
    public partial class GameOver : Form
    {
        private string _heroName;
        private int _waveCount;
        private bool _hasSubmitted = false;

        private MainMenu mw;

        public GameOver(string hName, int wave, bool isPlayerAlive, MainMenu main)
        {
            InitializeComponent();

            _heroName = hName;
            mw = main;
            _waveCount = wave;

            if (isPlayerAlive)
            {
                lblText.Text = "YOU WON!";
                lblText.ForeColor = Color.Green;
            }
            else
            {
                lblText.Text = "YOU HAVE DIED!";
                lblText.ForeColor = Color.Red;
            }
        }

        private void BtnDB_Click(object sender, EventArgs e)
        {
            if (!_hasSubmitted)
            {
                string pName = Interaction.InputBox("Your Name", "Input Name");

                mw.Database.InsertScore(pName, _heroName, _waveCount);

                _hasSubmitted = true;
            }
            else
            {
                MessageBox.Show("Already submitted score");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            mw.Show();
            this.Close();
        }
    }
}
