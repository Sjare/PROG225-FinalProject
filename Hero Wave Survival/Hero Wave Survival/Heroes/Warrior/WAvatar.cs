using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hero_Wave_Survival.Items;

namespace Hero_Wave_Survival.Heroes.Warrior
{
    public partial class WAvatar : UserControl
    {
        public WAvatar(string name, int hp, int level, int arm, int d, int s, int g, int exp, int acc,int dam, Stack<IItem> items)
        {
            InitializeComponent();
            lblAcc.Text = acc.ToString();
            lblArmor.Text = arm.ToString();
            lblDamage.Text = dam.ToString();
            lblDodge.Text = d.ToString();
            lblEXP.Text = exp.ToString();
            lblGold.Text = g.ToString();
            lblHP.Text = hp.ToString();
            lblLevel.Text = level.ToString();
            lblName.Text = name;
            lblSpeed.Text = s.ToString();
            lblHPCount.Text = items.Count.ToString();
        }

        public void updateAvatar(int hp, int level, int arm, int d, int s, int g, int exp, int acc, int dam, Stack<IItem> items)
        {
            lblAcc.Text = acc.ToString();
            lblArmor.Text = arm.ToString();
            lblDamage.Text = dam.ToString();
            lblDodge.Text = d.ToString();
            lblEXP.Text = exp.ToString();
            lblGold.Text = g.ToString();
            lblHP.Text = hp.ToString();
            lblLevel.Text = level.ToString();
            lblSpeed.Text = s.ToString();
            lblHPCount.Text = items.Count.ToString();
        }
    }
}
