using Hero_Wave_Survival.Heroes;
using Hero_Wave_Survival.Monsters;
using Hero_Wave_Survival.Monsters.Zombie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Wave_Survival.Game_Controller
{
    public class GameController
    {
        private BaseHero hero;

        //private List<BaseMonster> monsters = new List<BaseMonster>();

        private int _waveState = 1;

        public GameController(BaseHero Hero)
        {
            hero = Hero;
        }

        public List<BaseMonster> WaveSpawner()
        {
            List<BaseMonster> monsters = new List<BaseMonster>();

            switch (_waveState)
            {
                case 1:
                    _waveState++;
                    for (int i = 0; i < 3; i++)
                    {
                        monsters.Add(new Zombie());
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }

            return monsters;
        }
    }
}
