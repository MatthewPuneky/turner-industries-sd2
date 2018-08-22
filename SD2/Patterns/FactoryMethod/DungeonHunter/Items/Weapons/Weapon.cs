using SD2.Patterns.FactoryMethod.DungeonHunter.Characters;
using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public abstract class Weapon : IDescribable
    {
        private Character _weilder;
        public Character Weilder {
            get => _weilder;
            set
            {
                _weilder = value;
                if (value != null && value.Weapon != this) value.EquipWeapon(this);
            }
        }

        public abstract WeaponType WeaponType { get; }
        public abstract string Name { get; }
        public abstract int AttackPower { get; }
        public abstract int Range { get; }
        public abstract int DamageMultiplyer { get; }
        public abstract Attribute EnhancingAttribute { get; }

        public int Use()
        {
            PrintWeaponAttack();
            return AttackPower;
        }

        public abstract void PrintWeaponAttack();
        public abstract void PrintDescription();
    }

    public enum WeaponType
    {
        Unarmed = 1,
        Axe = 2, 
        Dagger = 3,
        Bow = 4,
        Wand = 5
    }
}
