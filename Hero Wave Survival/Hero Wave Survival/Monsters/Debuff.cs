using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Monsters
{
    public class Debuff
    {
        public string Stat;
        public int Value;
        public DateTime timestamp;

        public Debuff()
        {
            timestamp = DateTime.Now;
        }
    }
}
