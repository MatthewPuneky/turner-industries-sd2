using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Wand
{
    public class WarpedWand : Wand
    {
        public override string Name => "Warped Wand";
        public override int AttackPower => 1;

        public override void PrintDescription()
        {
            Console.WriteLine("The wand is so warped it's incredible it can even fire straight.");
        }

        public override void PrintWeaponAttack()
        {
            Console.WriteLine("Thin magic streams crackle out of the wand!");
        }
    }
}
