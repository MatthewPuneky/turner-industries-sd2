using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Axes
{
    public abstract class Axe : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Axe;
        public override int DamageMultiplyer => 3;
        public override int Range => 1;
        public override Attribute EnhancingAttribute => Weilder.Strength;
    }
}
