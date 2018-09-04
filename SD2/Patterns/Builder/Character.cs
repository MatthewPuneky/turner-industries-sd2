using SD2.SharedFeatures.Printers;

namespace SD2.Patterns.Builder
{
    public class Character
    {
        public string Name { get; set; }

        public string Armor { get; set; }
        public string Weapon { get; set; }

        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }

        public void Describe()
        { 
            Printer.PrintLine("YOUR BUILT CHARACTER");
            Printer.PrintLine($"Armor: {Armor}");
            Printer.PrintLine($"Weapon: {Weapon}");
            Printer.PrintLine($"Strength: {Strength}");
            Printer.PrintLine($"Intelligence: {Intelligence}");
            Printer.PrintLine($"Dexterity: {Dexterity}");
            Printer.PrintLine();
        }
    }
}
