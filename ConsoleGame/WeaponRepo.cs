using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class WeaponRepo
    {
        private Weapon _weapon;

        public void CreateOffence(string name, WeaponType type)
        {
            _weapon = new Weapon
            {
                Name = name,
                Type = type,
                AttackBonus = AttackGen(type)
            };
        }

        private int AttackGen(WeaponType type)
        {
            if (type == WeaponType.Rock)
            {
                Random rock = new Random();
                int gen = rock.Next(1, 6);
                return gen;
            }
            if (type == WeaponType.Stick)
            {
                Random stick = new Random();
                int gen = stick.Next(3, 10);
                return gen;
            }
            if (type == WeaponType.Bow)
            {
                Random bow = new Random();
                int gen = bow.Next(7, 16);
                return gen;
            }
            if (type == WeaponType.Sword)
            {
                Random sword = new Random();
                int gen = sword.Next(10, 21);
                return gen;
            }
            if (type == WeaponType.Axe)
            {
                Random axe = new Random();
                int gen = axe.Next(10, 25);
                return gen;
            }
            if (type == WeaponType.Hammer)
            {
                Random hammer = new Random();
                int gen = hammer.Next(12, 29);
                return gen;
            }
            else { return 7; }
        }

        public Weapon WeaponDetails() { return _weapon; }
    }
}
