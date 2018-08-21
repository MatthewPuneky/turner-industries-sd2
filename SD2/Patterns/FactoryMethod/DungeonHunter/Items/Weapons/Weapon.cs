using SD2.Patterns.FactoryMethod.DungeonHunter.Common;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public abstract class Weapon : IDescribable
    {
        public string WeaponName { get; }
        public int AttackPower { get; }

        protected Weapon(string weaponName, int attackPower)
        {
            WeaponName = weaponName;
            AttackPower = attackPower;
        }

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
        Unarmed = 1
    }
}
