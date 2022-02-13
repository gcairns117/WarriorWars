namespace WarriorWars.Equipment.Weapons
{
    class Sword
    {
        private const int DAMAGE = 10;
        private const int HIT_MODIFIER = 8;

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

        public Sword()
        {
            this.damage = DAMAGE;
            this.hitModifier = HIT_MODIFIER;
        }
    }
}
