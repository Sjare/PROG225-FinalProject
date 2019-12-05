using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Items
{
    public class HealthPotion : IItem
    {
        private int _uses = 2;
        private int _price = 1;
        private int _hpRestore = 50;

        private string _desc = "A vial filled with restorative waters. Will heal 50 hit points to the hero upon use";

        public int Uses { get { return _uses; } }
        public int Price { get { return _price; } }

        public int RestoreHP { get { return _hpRestore; } }

        public string Description { get { return _desc; } }

        public HealthPotion()
        {

        }

        public override string ToString()
        {
            return Description;
        }
    }
}
