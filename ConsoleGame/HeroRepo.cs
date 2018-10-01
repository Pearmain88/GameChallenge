using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class HeroRepo
    {
        private Hero _hero;

        public void CreateHero(string name, HeroRace type)
        {
            _hero = new Hero
            {
                Name = name,
                Health = HealthGen(),
                Race = type,
                AttackPower = AttackGen()
            };
        }

        private int HealthGen()
        {
            Random rnd = new Random();
            int random = rnd.Next(100, 501);
            return random;
        }

        private int AttackGen()
        {
            Random rnd = new Random();
            int random = rnd.Next(10, 51);
            return random;
        }

        public Hero HeroDetails()
        {
            return _hero;
        }

        public void TakeDamage(int attackDamage)
        {
            _hero.Health -= attackDamage;
        }

        public void Heal(int heal)
        {
            _hero.Health += 10;
        }
    }
}
