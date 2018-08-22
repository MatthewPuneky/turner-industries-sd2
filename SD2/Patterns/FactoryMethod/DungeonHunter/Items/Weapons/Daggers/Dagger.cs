using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Daggers
{
    public abstract class Dagger : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Dagger;
        public override int DamageMultiplyer => 2;
        public override int Range => 1;
        public override Attribute EnhancingAttribute => Weilder.Dexterity;
    }
}
