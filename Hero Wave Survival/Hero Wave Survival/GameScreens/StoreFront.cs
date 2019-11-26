using Hero_Wave_Survival.Heroes;
using Hero_Wave_Survival.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.GameScreens
{
    public partial class StoreFront : Form
    {
        private Stack<HealthPotion> healthPotions = new Stack<HealthPotion>();
        private BaseHero _hero;

        public StoreFront(BaseHero hero)
        {
            InitializeComponent();

            _hero = hero;

            for(int i = 0; i < 5; i++)
            {
                healthPotions.Push(new HealthPotion());
            }

            lblHPDesc.Text = healthPotions.Peek().Description;
            lblStock.Text = "Stock: " + healthPotions.Count.ToString();
            lblGold.Text = _hero.Gold.ToString();
        }

        private void BtnBuyHP_Click(object sender, EventArgs e)
        {
            if (_hero.Gold != 0)
            {
                if (healthPotions.Count != 0)
                {
                    HealthPotion buffer = healthPotions.Pop();

                    _hero.Backpack.Push(buffer);
                    _hero.Gold -= buffer.Price;

                    _hero.updateAvatar();

                    lblGold.Text = _hero.Gold.ToString();
                    lblStock.Text = healthPotions.Count.ToString();
                }
            }

            //TODO: Come back and add error screens for not enough gold or out of stock
        }

        private void BtnExitShop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
