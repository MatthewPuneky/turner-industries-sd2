using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Weapons.Bow
{
    public class RicketyBow : Bow
    {
        public override string Name => "Rickety Bow";
        public override int AttackPower => 1;

        public override void PrintDescription()
        {
            Printer.WriteLine("Cracked from top to bottom, but it can still shoot");
        }

        public override void PrintWeaponAttack()
        {
            Printer.WriteLine("The bow creeks as the arrow hurls towards its target!");
        }
    }
}
