using BrawlingBuddies.Enum;

namespace BrawlingBuddies.Equipment
{
    public class Weapon
    {
        private const int PLAYER_ONE_DAMAGE = 50;
        private const int PLAYER_TWO_DAMAGE = 50;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            if (faction == Faction.PlayerOne)
            {
                damage = PLAYER_ONE_DAMAGE;
            }
            else if (faction == Faction.PlayerTwo)
            {
                damage = PLAYER_TWO_DAMAGE;
            }
        }
    }

}
