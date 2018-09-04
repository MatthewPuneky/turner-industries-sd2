using System.Collections.Generic;
using SD2.SharedFeatures.Menus;
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
            var information = new List<string>
            {
                "YOUR BUILT CHARACTER",
                $"Armor: {Armor}",
                $"Weapon: {Weapon}",
                $"Strength: {Strength}",
                $"Intelligence: {Intelligence}",
                $"Dexterity: {Dexterity}"
            };

            MenuFactory.SimpleMessagesInformational(information).Display();
        }
    }
}
