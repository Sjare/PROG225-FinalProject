using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Items
{
    public interface IItem
    {
        int Uses { get;}
        int Price { get;}

        string Description { get; }
    }
}
