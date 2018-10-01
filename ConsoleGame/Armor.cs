using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public enum ArmorType { Basic =1, Shiny, Badass, Epic }

    class Armor
    {
        public string Name { get; set; }
        public ArmorType Type { get; set; }
        public int Defence { get; set; }
    }
}
