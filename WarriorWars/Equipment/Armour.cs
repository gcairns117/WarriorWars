using WarriorWars.Enum;
namespace WarriorWars.Equipment
{
    class Armour
    {
        private const int HEAVY_ARMOUR = 5;
        private const int LIGHT_ARMOUR = 3;

        private int armourPoints;

        public int ArmourPoints
        { 
            get { return armourPoints; }
        }

        public Armour(Faction faction)
        {
            switch (faction)
            {
                case Faction.RedTeam:
                    armourPoints = HEAVY_ARMOUR;
                    break;
                case Faction.BlueTeam:
                    armourPoints = LIGHT_ARMOUR;
                    break;
                default:
                    break;
            }
        }
    }
}