using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Wand
{
    public abstract class Wand : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Wand;
        public override int DamageMultiplyer => 3;
        public override int Range => 7;
        public override Attribute EnhancingAttribute => Weilder.Inteligence;
    }
}
