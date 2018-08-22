using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Bow
{
    public abstract class Bow : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Bow;
        public override int DamageMultiplyer => 2;
        public override int Range => 5;
        public override Attribute EnhancingAttribute => Weilder.Dexterity;
    }
}
