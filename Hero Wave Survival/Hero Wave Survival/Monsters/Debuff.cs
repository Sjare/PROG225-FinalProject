using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Monsters
{
    public class Debuff
    {
        //private variables
        public string Stat;
        public int Value;

        //private objects
        public DateTime timestamp;

        public Debuff()
        {
            timestamp = DateTime.Now;
        }
    }
}
