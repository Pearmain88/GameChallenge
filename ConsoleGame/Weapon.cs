using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public enum WeaponType { Rock = 1, Stick, Bow, Sword, Axe, Hammer }
    class Weapon
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }
        public WeaponType Type { get; set; }
    }
}
