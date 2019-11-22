using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Monsters.Zombie
{
    public class Zombie : BaseMonster
    {
        public Zombie()
        {
            Health = 30;
            Armor = 0;
            Speed = 1;
            Damage = 10;
            EXP = 1;
            Dodge = 0;
            Worth = 1;
            Avatar = new ZAvatar(this.Health);
            Avatar.Click += Avatar_Click;
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
