using System;
using BrawlingBuddies.Enum;
using BrawlingBuddies.Equipment;

namespace BrawlingBuddies
{
    public class Fighter
    {
        private const int PLAYER_ONE_STARTING_HEALTH = 100;
        private const int PLAYER_TWO_STARTING_HEALTH = 100;

        private readonly Faction faction;

        private string name;
        private int health;
        private bool isAlive;

        private Weapon weapon;
        private Armor armor;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public Fighter(string name, Faction faction)
        {
            this.name = name;
            this.faction = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.PlayerOne:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = PLAYER_ONE_STARTING_HEALTH;
                    break;
                case Faction.PlayerTwo:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = PLAYER_TWO_STARTING_HEALTH;
                    break;
                default:
                    break;
            }

        }

        public void Attack(Fighter enemyFighter)
        {
            int damage = weapon.Damage / enemyFighter.armor.ArmorPoints;

            enemyFighter.health = enemyFighter.health - damage;

            AttackResult(enemyFighter, damage);

        }

        private void AttackResult(Fighter enemyFighter, int damage)
        {
            if (enemyFighter.health <= 0)
            {
                enemyFighter.isAlive = false;

                Misc.ColorWriteLine($"{name} has won!", ConsoleColor.Green);
                Misc.ColorWriteLine($"{enemyFighter.name}, better luck next time...", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemyFighter.name} for {damage}.\n" +
                    $"{name} current health: {health}\n" +
                    $"{ enemyFighter.name} current health: { enemyFighter.health}\n" +
                    new string('-', 40) + "\n");
            }
        }
    }
}
