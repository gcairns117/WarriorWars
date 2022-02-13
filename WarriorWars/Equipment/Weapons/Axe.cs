namespace WarriorWars.Equipment.Weapons
{
    class Axe
    {
        private const int DAMAGE = 14;
        private const int HIT_MODIFIER = 6;

        private int damage;
        private int hitModifier;

        public int Damage
        { 
            get { return damage; } 
        }
        public int HitModifier 
        { 
            get { return hitModifier; } 
        }

        public Axe()
        {
            this.damage = DAMAGE;
            this.hitModifier = HIT_MODIFIER;
        }

    }
}
