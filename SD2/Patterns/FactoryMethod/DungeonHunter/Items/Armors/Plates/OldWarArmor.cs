using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.FactoryMethod.DungeonHunter.Items.Armors.Plates
{
    public class OldWarArmor : Plate
    {
        public override string ArmorName => "Old War Armor";
        public override int ArmorRaiting => 3;
        public override ArmorWeight ArmorWeight => ArmorWeight.Heavy;

        public override void Describe()
        {
            Printer.WriteLine("This armor was definitely used in a war, gashes all over but will offer some protection.");
        }
    }
}
