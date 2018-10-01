using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class EnemyRepo
    {
        private Enemy _enemy;

        public void CreateCharacter(string name)
        {
            _enemy = new Enemy
            {
                Name = name,
                AttackPower = AttackGen(),
                Health = HealthGen(),
                Race = RaceGen()
            };
        }

        private EnemyRace RaceGen()
        {
            Random random = new Random();
            return (EnemyRace)random.Next(Enum.GetNames(typeof(EnemyRace)).Length);
        }

        private int HealthGen()
        {
            Random rnd = new Random();
            int random = rnd.Next(100, 701);
            return random;
        }

        private int AttackGen()
        {
            Random rnd = new Random();
            int random = rnd.Next(10, 51);
            return random;
        }

        public Enemy EnemyDetails() { return _enemy; }

        public void TakeDamage(int attackDamage) { _enemy.Health -= attackDamage; }

        public void Heal(int heal) { _enemy.Health += 2; }
    }
}
