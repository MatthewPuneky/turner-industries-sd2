﻿using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Axes
{
    public class RustyAxe : Axe
    {
        private int BaseDamageValue = 1;

        public override string Name => "Rusty Axe";
        public override int AttackPower => EnhancingAttribute.Value * BaseDamageValue * DamageMultiplyer;

        public override void Describe()
        {
            Printer.PrintLine("It's so dull only brute force can make use of this.");
        }

        public override void PrintWeaponAttack()
        {
            Printer.PrintLine("The Rusty Axe lumbers through the air!");
        }
    }
}
