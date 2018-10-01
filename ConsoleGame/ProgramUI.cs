using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class ProgramUI
    {
        private HeroRepo _heroRepo = new HeroRepo();
        private EnemyRepo _enemyRepo = new EnemyRepo();
        private ArmorRepo _armorRepo = new ArmorRepo();
        private MagicRepo _magicRepo = new MagicRepo();
        private WeaponRepo _weaponRepo = new WeaponRepo();

        public void Run()
        {
            SetUpGame();
            PlayGame();
            EndGame();
        }

        private void SetUpGame()
        {
            SelectHero();
            SelectArmor();
            SelectWeapon();
            SelectMagic();
            GenEnemy();
            ShowAllStats();
        }

        private void SelectHero()
        {
            Console.WriteLine("What is your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine("What kind of hero are you?\n" +
                "1. Human\n" +
                "2. Wizard\n" +
                "3. Dwarf\n" +
                "4. Elf\n");
            string type = Console.ReadLine();
            HeroRace newHero = (HeroRace)Enum.Parse(typeof(HeroRace), type);
            _heroRepo.CreateHero(name, newHero);
        }

        private void SelectArmor()
        {
            Console.WriteLine("What is the name of your armor?\n");
            string name = Console.ReadLine();
            Console.WriteLine("What kind of armor do you have?\n" +
                "1. Basic\n" +
                "2. Shiny\n" +
                "3. Badass\n" +
                "4. Epic\n");
            string type = Console.ReadLine();
            ArmorType newType = (ArmorType)Enum.Parse(typeof(ArmorType), type);
            _armorRepo.CreateArmor(name, newType);

        }

        private void SelectWeapon()
        {
            Console.WriteLine("What is the name of your weapon?");
            string name = Console.ReadLine();
            Console.WriteLine("What kind of weapon do you have?\n" +
                "1. Rock\n" +
                "2. Stick\n" +
                "3. Bow and Arrow\n" +
                "4. Sword\n" +
                "5. Axe\n" +
                "6. Hammer\n");
            string type = Console.ReadLine();
            WeaponType newType = (WeaponType)Enum.Parse(typeof(WeaponType), type);
            _weaponRepo.CreateOffence(name, newType);
        }

        private void SelectMagic()
        {
            Console.WriteLine("What is the name of your magical attack?\n");
            string name = Console.ReadLine();
            _magicRepo.CreateOffence(name);
        }

        private void GenEnemy()
        {
            Console.WriteLine("Give your enemy a name...");
            string name = Console.ReadLine();
            _enemyRepo.CreateCharacter(name);
        }

        private void ShowAllStats()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();
            var armor = _armorRepo.ArmorDetails();
            var magic = _magicRepo.MagicDetails();
            var weapon = _weaponRepo.WeaponDetails();

            Console.WriteLine($"Hero: {hero.Name} Race: {hero.Race} Health: {hero.Health} Attack: {hero.AttackPower}\n" +
                $"Armor: {armor.Name} Type: {armor.Type} Defence: {armor.Defence}\n" +
                $"Weapon: {weapon.Name} Type: {weapon.Type} Attack: {weapon.AttackBonus}\n" +
                $"Magic: {magic.Name} Attack: {magic.AttackBonus}\n" +
                $"Enemy: {enemy.Name} Race:{enemy.Race} Health {enemy.Health} Attack {enemy.AttackPower}");
        }

        private void PlayGame()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();
            while (hero.Health > 0 && enemy.Health >0)
            {
                PromptPlayer();
            }
        }

        private void PromptPlayer()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1. Attack\n" +
                "2. Hide\n" +
                "3. Magic Attack\n");

            int input = int.Parse(Console.ReadLine());
            HandleInput(input);
        }

        private void HandleInput(int input)
        {
            switch (input)
            {
                case 1:
                    Attack();
                    break;
                case 2:
                    Hide();
                    break;
                case 3:
                    Flee();
                    break;
                case 4:
                    MagicAttack();
                    break;
                default:
                    break;
            }
        }

        private void Attack()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();
            var weapon = _weaponRepo.WeaponDetails();
            var armor = _armorRepo.ArmorDetails();

            _enemyRepo.TakeDamage(hero.AttackPower + weapon.AttackBonus);
            _heroRepo.TakeDamage(enemy.AttackPower - armor.Defence);

            Console.WriteLine($"{hero.Name}'s health is: {hero.Health}");
            Console.WriteLine($"{enemy.Name}'s health is: {enemy.Health}");
        }

        private void Hide()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();

            Console.WriteLine("You are hidden, no one can attack, you will recover some health");

            _heroRepo.Heal(hero.HealChar);
            _enemyRepo.Heal(enemy.HealChar);

            Console.WriteLine($"{hero.Name}'s health is: {hero.Health}");
            Console.WriteLine($"{enemy.Name}'s health is: {enemy.Health}");
        }

        private void MagicAttack()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();
            var magic = _magicRepo.MagicDetails();
            var armor = _armorRepo.ArmorDetails();

            _enemyRepo.TakeDamage(hero.AttackPower + magic.AttackBonus);
            _heroRepo.TakeDamage(enemy.AttackPower - armor.Defence);

            Console.WriteLine($"{hero.Name}'s health is: {hero.Health}");
            Console.WriteLine($"{enemy.Name}'s health is: {enemy.Health}");
        }

        private void EndGame()
        {
            var hero = _heroRepo.HeroDetails();
            var enemy = _enemyRepo.EnemyDetails();
            var playGame = true;
            while (hero.Health > 0 && enemy.Health > 0)
            {
                playGame = true;
            }
            if (hero.Health <= 0)
            {
                playGame = false;
                Console.WriteLine("You lose");
            }
            if (enemy.Health <= 0)
            {
                playGame = false;
                Console.WriteLine("Yay you win");
            }            
        }
    }
}
