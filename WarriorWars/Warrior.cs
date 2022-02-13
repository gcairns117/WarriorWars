using WarriorWars.Enum;
using WarriorWars.Equipment;
using WarriorWars.Equipment.Weapons;

namespace WarriorWars
{
    class Warrior
    {
        private const int STARTING_HEALTH = 25;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Sword sword;
        private Axe axe;
        private Armour armour; 

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.RedTeam:
                    axe = new Axe();
                    armour = new Armour(faction);
                    health = STARTING_HEALTH;
                    break;
                case Faction.BlueTeam:
                    sword = new Sword();
                    armour = new Armour(faction);
                    health = STARTING_HEALTH;
                    break;
                default:
                    break;
            }

        }

        public int getWeaponDmg(Warrior self)
        {
            switch (self.FACTION)
            {
                case Faction.RedTeam:
                    int aDmg = axe.Damage;
                    return aDmg;
                case Faction.BlueTeam:
                    int sDmg = sword.Damage;
                    return sDmg;
                default:
                    return 0;
            }
        }

        public int getModifier(Warrior self)
        {
            switch (self.FACTION)
            {
                case Faction.RedTeam:
                    int aMod = axe.HitModifier;
                    return aMod;
                case Faction.BlueTeam:
                    int sMod = sword.HitModifier;
                    return sMod;
                default:
                    return 0;
            }
        }

        public void Attack(Warrior self, Warrior opponent)
        {
            int damage = getWeaponDmg(self) / opponent.armour.ArmourPoints;
            opponent.health -= damage;
            AttackResult(self, opponent, damage);
        }

        private static void AttackResult(Warrior self, Warrior opponent, int damage)
        {
            if (opponent.health <= 0)
            {
                opponent.isAlive = false;
                Tools.ColourWriteLine($"{opponent.name} has been defeated!", ConsoleColor.Red);
                Tools.ColourWriteLine($"All the glory goes to {self.name}!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{self.name} has dealt {damage} damage to {opponent.name}!");
                Console.WriteLine($"{opponent.name} has {opponent.health} health remaining.");
                Console.WriteLine("------");
            }
        }
    }
}
