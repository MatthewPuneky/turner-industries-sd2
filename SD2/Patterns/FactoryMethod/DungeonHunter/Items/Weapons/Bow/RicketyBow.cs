using System;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Bow
{
    public class RicketyBow : Bow
    {
        public override string Name => "Rickety Bow";
        public override int AttackPower => 1;

        public override void PrintDescription()
        {
            Console.WriteLine("Cracked from top to bottom, but it can still shoot");
        }

        public override void PrintWeaponAttack()
        {
            Console.WriteLine("The bow creeks as the arrow hurls towards its target!");
        }
    }
}
