using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public enum HeroRace { Human = 1, Wizard, Dwarf, Elf }

    class Hero
    {
        public string Name { get; set; } 
        public int Health { get; set; }     
        public HeroRace Race { get; set; }  
        public int AttackPower { get; set; }
        public int HealChar { get; set; }
    }
}
