using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons
{
    public class Unarmed : Weapon
    {
        public override WeaponType WeaponType => WeaponType.Unarmed;
        public override string Name => "Unarmed";
        public override int AttackPower => 1;
        public override int Range => 1;
        public override int DamageMultiplyer => 1;
        public override Characters.Attribute EnhancingAttribute => Weilder.Strength;

        public override void PrintWeaponAttack()
        {
            Console.WriteLine("Fists fly violently through the air.");
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Only knuckles for bare fist brawling.");
        }
    }
}
