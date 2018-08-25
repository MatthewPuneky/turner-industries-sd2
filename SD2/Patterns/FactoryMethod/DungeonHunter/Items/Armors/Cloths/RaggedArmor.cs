using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors.Cloths
{
    class RaggedArmor : Cloth
    {
        public override string ArmorName => "Ragged Armor";
        public override int ArmorRaiting => 1;
        public override ArmorWeight ArmorWeight => ArmorWeight.None;

        public override void PrintDescription()
        {
            Printer.WriteLine("Holes all over, but at least it keeps the cold out.");
        }
    }
}
