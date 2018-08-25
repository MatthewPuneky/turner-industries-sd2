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
            Printer.WriteLine("YOUR BUILT CHARACTER");
            Printer.WriteLine($"Armor: {Armor}");
            Printer.WriteLine($"Weapon: {Weapon}");
            Printer.WriteLine($"Strength: {Strength}");
            Printer.WriteLine($"Intelligence: {Intelligence}");
            Printer.WriteLine($"Dexterity: {Dexterity}");
            Printer.WriteLine();
        }
    }
}
