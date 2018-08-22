using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Daggers
{
    public class RustyDagger : Dagger
    {
        private int BaseDamageValue = 1;

        public override string Name => "Rusty Dagger";
        public override int AttackPower => EnhancingAttribute.Value * BaseDamageValue * DamageMultiplyer;
        public override int Range => 1;

        public override void PrintDescription()
        {
            Console.WriteLine("It might as well be a kitchen knife.");
        }

        public override void PrintWeaponAttack()
        {
            Console.WriteLine("The Rusty Dagger flings towrads its opponent!");
        }
    }
}
