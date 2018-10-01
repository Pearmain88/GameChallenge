using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class MagicRepo
    {
        private Magic _magic;

        public void CreateOffence(string name)
        {
            _magic = new Magic
            {
                Name = name,
                AttackBonus = AttackGen()                
            };
        }

        private int AttackGen()
        {
            Random random = new Random();
            int gen = random.Next(10, 26);
            return gen;
        }

        public Magic MagicDetails() { return _magic; }
    }
}
