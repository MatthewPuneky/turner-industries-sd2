using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors
{
    public class Unarmored : Armor
    {
        public override ArmorType ArmorType => ArmorType.Unarmoed;
        public override ArmorWeight ArmorWeight => ArmorWeight.None;
        public override string ArmorName => "Unarmed";
        public override int ArmorRaiting => 0;

        public override void Describe()
        {
            Printer.WriteLine("Unarmored, like the day you were born.");
        }
    }
}
