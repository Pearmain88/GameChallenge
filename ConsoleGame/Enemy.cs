using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public enum EnemyRace { Witch, Dragon, Goblin, Ogre }
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public EnemyRace Race { get; set; }
        public int AttackPower { get; set; }
        public int HealChar { get; set; }
    }
}
