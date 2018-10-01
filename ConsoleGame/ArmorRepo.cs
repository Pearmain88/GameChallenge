using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class ArmorRepo
    {
        private Armor _armor;
        
        public void CreateArmor(string name, ArmorType type)
        {
            _armor = new Armor
            {
                Name = name,
                Type = type,
                Defence = GenDefense(type)
            };       
        }

        private int GenDefense(ArmorType type)
        {
            if (type == ArmorType.Basic)
            {
                Random basic = new Random();
                int rBasic = basic.Next(5, 16);
                return rBasic;
            }
            if (type == ArmorType.Shiny)
            {
                Random shiny = new Random();
                int rShiny = shiny.Next(10, 21);
                return rShiny;
            }
            if (type == ArmorType.Badass)
            {
                Random badass = new Random();
                int rBadass = badass.Next(15, 26);
                return rBadass;
            }
            if (type == ArmorType.Epic)
            {
                Random epic = new Random();
                int rEpic = epic.Next(20, 31);
                return rEpic;
            }
            else { return 7; }
        }

        public Armor ArmorDetails() { return _armor; }
    }
}
