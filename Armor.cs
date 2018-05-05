using BrawlingBuddies.Enum;

namespace BrawlingBuddies.Equipment
{
    public class Armor
    {
        private const int PLAYER_ONE_ARMOR_POINTS = 10;
        private const int PLAYER_TWO_ARMOR_POINTS = 10;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            if (faction == Faction.PlayerOne)
            {
                armorPoints = PLAYER_ONE_ARMOR_POINTS;
            }
            else if (faction == Faction.PlayerTwo)
            {
                armorPoints = PLAYER_TWO_ARMOR_POINTS;
            }
        }
    }
}
