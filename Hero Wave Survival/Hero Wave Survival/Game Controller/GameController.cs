using Hero_Wave_Survival.GameScreens;
using Hero_Wave_Survival.Heroes;
using Hero_Wave_Survival.Monsters;
using Hero_Wave_Survival.Monsters.Skeleton;
using Hero_Wave_Survival.Monsters.Zombie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero_Wave_Survival.Game_Controller
{
    public class GameController
    {
        private BaseHero hero;
        private Arena arena;
        private MainMenu mw;
        private List<BaseMonster> monsters = new List<BaseMonster>();
        private Timer stateChecker;
        private int _waveState = 1;
        private int _killCount = 0;
        private bool _hasStarted = false;

        public GameController(BaseHero Hero, Arena A, MainMenu main)
        {
            hero = Hero;
            arena = A;
            mw = main;
            stateChecker = new Timer();
            stateChecker.Interval = 1;
            stateChecker.Enabled = true;
            stateChecker.Tick += StateChecker_Tick;
        }

        private void StateChecker_Tick(object sender, EventArgs e)
        {
            if (hero.isAlive)
            {
                //game continues as long as hero is alive

                //checking if monsters are dead and removing them accordingly and displaying intermission
                //buttons
                if (monsters.Count == 0 && _hasStarted)
                {
                    arena.btnNextWave.Visible = true;
                    arena.btnClose.Visible = true;
                    arena.btnStore.Visible = true;
                }
                else
                {
                    for (int i = 0; i < monsters.Count; i++)
                    {
                        if (!monsters[i].isAlive)
                        {
                            arena.tbEnem.Controls.Remove(monsters[i].Avatar);
                            monsters.RemoveAt(i);
                        }
                    }
                }
            }
            else
            {
                //end game if hero dies
                foreach(BaseMonster monster in monsters)
                {
                    monster.Kill();
                }
                stateChecker.Stop();
                GameOver gameOver = new GameOver(hero.Name, _waveState, hero.isAlive,mw);
                gameOver.Show();
                arena.Close();
            }

            GC.Collect();
        }

        public void WaveSpawner()
        {
            _hasStarted = true;

            arena.btnNextWave.Visible = false;
            arena.btnClose.Visible = false;
            arena.btnStore.Visible = false;

            switch (_waveState)
            {
                case 1:

                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 1; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach(BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    
                    break;
                case 2:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 3:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    for(int i = 0; i < 1; i++)
                    {
                        monsters.Add(new Skeleton(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 4:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Skeleton(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 5:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 6:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 7:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 8:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 9:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
                case 10:
                    //increment my wave state
                    _waveState++;

                    //make my monsters
                    for (int i = 0; i < 2; i++)
                    {
                        monsters.Add(new Zombie(hero));
                    }

                    //add the monsters to the arena
                    foreach (BaseMonster monster in monsters)
                    {
                        arena.tbEnem.Controls.Add(monster.Avatar);
                        monster.Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
                    }
                    break;
            }
        }
    }
}
